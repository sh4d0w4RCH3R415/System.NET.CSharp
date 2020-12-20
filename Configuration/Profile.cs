using System.Data;

namespace System.NET.CSharp.Configuration
{
	public abstract class Profile : IProfile, IReadOnlyProfile, ICloneable
	{
		private string m_name;
		private bool m_readOnly;

		public event ProfileChangingHandler Changing;
		public event ProfileChangedHandler Changed;

		protected Profile() => m_name = DefaultName;
		protected Profile(string name) => m_name = name;
		protected Profile(Profile profile)
		{
			m_name = profile.m_name;
			m_readOnly = profile.m_readOnly;
			Changing = profile.Changing;
			Changed = profile.Changed;
		}

		public string Name
		{
			get { return m_name; }
			set
			{
				VerifyNotReadOnly();
				if (m_name == value.Trim() || !RaiseChangeEvent(true, ProfileChangeType.Name, null, null, value))
					return;
				m_name = value.Trim();
				RaiseChangeEvent(false, ProfileChangeType.Name, null, null, value);
			}
		}
		public bool ReadOnly
		{
			get { return m_readOnly; }
			set
			{
				VerifyNotReadOnly();
				if (m_readOnly == value || !RaiseChangeEvent(true, ProfileChangeType.ReadOnly, null, null, value))
					return;
				m_readOnly = value;
				RaiseChangeEvent(false, ProfileChangeType.ReadOnly, null, null, value);
			}
		}

		public abstract string DefaultName { get; }
		public abstract object Clone();
		public abstract void SetValue(string section, string entry, object value);
		public abstract object GetValue(string section, string entry);

		public virtual string GetValue(string section, string entry, string defaultValue)
		{
			object obj = GetValue(section, entry);
			return obj != null ? obj.ToString() : defaultValue;
		}
		public virtual int GetValue(string section, string entry, int defaultValue)
		{
			object obj = GetValue(section, entry);
			if (obj == null)
				return defaultValue;
			try
			{
				return Convert.ToInt32(obj);
			}
			catch
			{
				return 0;
			}
		}
		public virtual double GetValue(string section, string entry, double defaultValue)
		{
			object obj = GetValue(section, entry);
			if (obj == null)
				return defaultValue;
			try
			{
				return Convert.ToDouble(obj);
			}
			catch
			{
				return 0.0;
			}
		}
		public virtual bool GetValue(string section, string entry, bool defaultValue)
		{
			object obj = GetValue(section, entry);
			if (obj == null)
				return defaultValue;
			try
			{
				return Convert.ToBoolean(obj);
			}
			catch
			{
				return false;
			}
		}
		
		public virtual bool HasEntry(string section, string entry)
		{
			string[] entryNames = GetEntryNames(section);
			if (entryNames == null)
				return false;
			VerifyAndAdjustEntry(ref entry);
			return Array.IndexOf(entryNames, entry) >= 0;
		}
		public virtual bool HasSection(string section)
		{
			string[] sectionNames = GetSectionNames();
			if (sectionNames == null)
				return false;
			VerifyAndAdjustSection(ref section);
			return Array.IndexOf(sectionNames, section) >= 0;
		}

		public abstract void RemoveEntry(string section, string entry);
		public abstract void RemoveSection(string section);
		public abstract string[] GetEntryNames(string section);
		public abstract string[] GetSectionNames();

		public virtual IReadOnlyProfile CloneReadOnly()
		{
			Profile profile = (Profile)Clone();
			profile.m_readOnly = true;
			return profile;
		}
		public virtual DataSet GetDataSet()
		{
			VerifyName();
			string[] sectionNames = GetSectionNames();
			if (sectionNames == null)
				return null;
			DataSet dataSet = new DataSet(Name);
			foreach (string str1 in sectionNames)
			{
				DataTable dataTable = dataSet.Tables.Add(str1);
				string[] entryNames = GetEntryNames(str1);
				DataColumn[] columns = new DataColumn[entryNames.Length];
				object[] objArray = new object[entryNames.Length];
				int index = 0;
				foreach (string str2 in entryNames)
				{
					object obj = GetValue(str1, str2);
					columns[index] = new DataColumn(str2, obj.GetType());
					objArray[index++] = obj;
				}
				dataTable.Columns.AddRange(columns);
				dataTable.Rows.Add(objArray);
			}

			return dataSet;
		}
		public virtual void SetDataSet(DataSet ds)
		{
			if (ds == null)
				throw new ArgumentNullException(nameof(ds));
			foreach (DataTable table in ds.Tables)
			{
				string tableName = table.TableName;
				DataRowCollection rows = table.Rows;
				if (rows.Count != 0)
				{
					foreach (DataColumn column in table.Columns)
					{
						string columnName = column.ColumnName;
						object obj = rows[0][column];
						SetValue(tableName, columnName, obj);
					}
				}
			}
		}

		protected virtual void VerifyAndAdjustSection(ref string section)
		{
			if (section == null)
				throw new ArgumentNullException(nameof(section));
			section = section.Trim();
		}
		protected virtual void VerifyAndAdjustEntry(ref string entry)
		{
			if (entry == null)
				throw new ArgumentNullException(nameof(entry));
			entry = entry.Trim();
		}
		protected internal virtual void VerifyName()
		{
			if (m_name == null || m_name == "")
				throw new InvalidOperationException("Operation not allowed because Name property is null or empty.");
		}
		protected internal virtual void VerifyNotReadOnly()
		{
			if (m_readOnly)
				throw new InvalidOperationException("Operation not allowed because ReadOnly property is true.");
		}

		protected string DefaultNameWithoutExtension
		{
			get
			{
				try
				{
					string configurationFile = AppDomain.CurrentDomain.SetupInformation.ConfigurationFile;
					return configurationFile.Substring(0, configurationFile.LastIndexOf('.'));
				}
				catch
				{
					return "profile";
				}
			}
		}

		protected bool RaiseChangeEvent(bool changing, ProfileChangeType changeType, string section, string entry, object value)
		{
			if (changing)
			{
				if (Changing == null)
					return true;
				ProfileChangingArgs e = new ProfileChangingArgs(changeType, section, entry, value);
				OnChanging(e);
				return !e.Cancel;
			}
			if (Changed != null)
				OnChanged(new ProfileChangedArgs(changeType, section, entry, value));
			return true;
		}
		protected virtual void OnChanging(ProfileChangingArgs e)
		{
			if (Changing == null)
				return;
			foreach (ProfileChangingHandler invocation in Changing.GetInvocationList())
			{
				invocation(this, e);
				if (e.Cancel)
					break;
			}
		}
		protected virtual void OnChanged(ProfileChangedArgs e)
		{
			if (Changed == null)
				return;
			Changed(this, e);
		}
	}
}
