using System.Linq;
using System.Data.Entity;

namespace LEARNING_EF_CODE_FIRST
{
	public partial class MainForm : System.Windows.Forms.Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, System.EventArgs e)
		{
		}

		private void AddSomeNewCountriesButton_Click(object sender, System.EventArgs e)
		{
			Models.DatabaseContext databaseContext = null;

			try
			{
				databaseContext =
					new Models.DatabaseContext();

				bool hasAnyCountry =
					databaseContext.Countries.Any();

				if (hasAnyCountry)
				{
					return;
				}

				Models.Country country = null;

				// **************************************************
				// **************************************************
				// **************************************************
				country = new Models.Country
				{
					Code = 1,
					Name = "Iran",
				};

				databaseContext.Countries.Add(country);
				// **************************************************

				// **************************************************
				country = new Models.Country
				{
					Code = 2,
					Name = "Iraq",
				};

				databaseContext.Countries.Add(country);
				// **************************************************

				// **************************************************
				country = new Models.Country
				{
					Code = 3,
					Name = "Italy",
				};

				databaseContext.Countries.Add(country);
				// **************************************************

				// **************************************************
				country = new Models.Country
				{
					Code = 4,
					Name = "France",
				};

				databaseContext.Countries.Add(country);
				// **************************************************

				// **************************************************
				country = new Models.Country
				{
					Code = 5,
					Name = "Germany",
				};

				databaseContext.Countries.Add(country);
				// **************************************************
				// **************************************************
				// **************************************************

				databaseContext.SaveChanges();
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
			}
			finally
			{
				if (databaseContext != null)
				{
					databaseContext.Dispose();
					//databaseContext = null;
				}
			}
		}

		private void ShowAllCountriesButton_Click(object sender, System.EventArgs e)
		{
			Models.DatabaseContext databaseContext = null;

			try
			{
				databaseContext =
					new Models.DatabaseContext();

				// **************************************************
				// Note: Because of using .Load() (Extension) method and .Local (Extension) property,
				// We should write [using System.Data.Entity;] in top of source code.

				//// List
				//var countries =
				//	databaseContext.Countries
				//	.ToList()
				//	;

				//// Load
				//databaseContext.Countries
				//	.Load();

				//var countries =
				//	databaseContext.Countries.Local;
				// **************************************************

				// **************************************************
				// Solution (1)
				// **************************************************
				//databaseContext.Countries
				//	.Load();

				//databaseContext.Countries
				//	.OrderBy(current => current.Name)
				//	.Load();

				//databaseContext.Countries
				//	.Where(current => current.Code >= 10)
				//	.Load();

				//databaseContext.Countries
				//	.Where(current => current.Code >= 10)
				//	.OrderBy(current => current.Name)
				//	.Load();
				// **************************************************

				// **************************************************
				// **************************************************
				// **************************************************
				////countriesListBox.ValueMember = "Id";
				////countriesListBox.DisplayMember = "Name";

				//countriesListBox.ValueMember = nameof(Models.Country.Id);
				//countriesListBox.DisplayMember = nameof(Models.Country.Name);

				//countriesListBox.DataSource =
				//	databaseContext.Countries.Local;
				// **************************************************
				// **************************************************
				// **************************************************

				// **************************************************
				//countriesListBox.ValueMember = nameof(Models.Country.Id);
				//countriesListBox.DisplayMember = nameof(Models.Country.DisplayName);

				//countriesListBox.DataSource =
				//	databaseContext.Countries.Local;
				// **************************************************
				// /Solution (1)
				// **************************************************

				// **************************************************
				// Solution (2)
				// **************************************************
				//var countries =
				//	databaseContext.Countries
				//	.ToList()
				//	;

				var countries =
					databaseContext.Countries
					.OrderBy(current => current.Code)
					.ToList()
					;

				//var countries =
				//	databaseContext.Countries
				//	.Where(current => current.Code >= 10)
				//	.ToList()
				//	;

				//var countries =
				//	databaseContext.Countries
				//	.Where(current => current.Code >= 10)
				//	.OrderBy(current => current.Name)
				//	.ToList()
				//	;
				// **************************************************

				// **************************************************
				//countriesListBox.ValueMember = nameof(Models.Country.Id);
				//countriesListBox.DisplayMember = nameof(Models.Country.Name);

				//countriesListBox.DataSource = countries;
				// **************************************************

				// **************************************************
				countriesListBox.ValueMember = nameof(Models.Country.Id);
				countriesListBox.DisplayMember = nameof(Models.Country.DisplayName);

				countriesListBox.DataSource = countries;
				// **************************************************
				// /Solution (2)
				// **************************************************

				// **************************************************
				// Solution (3)
				// **************************************************
				//string query =
				//	"SELECT * FROM Countries ORDER BY Name ASC";

				//var countries =
				//	databaseContext.Database
				//	.SqlQuery<Models.Country>(query)
				//	.ToList()
				//	;

				// NHibernate در
				// int code = System.Convert.ToInt32(countries[0]["Code"]);

				// ADO.NET 1, 1.1
				// int code = System.Convert.ToInt32(dataSet.Tables["Countries"].Rows[0]["Code"]);

				// EF در
				// int code = countries[0].Code;
				// **************************************************

				// **************************************************
				// Note: [GetCountries] is Stored Procedure!
				//string query = "GetCountries";

				//var countries =
				//	databaseContext.Database
				//	.SqlQuery<Models.Country>(query)
				//	.ToList()
				//	;
				// **************************************************

				// **************************************************
				countriesListBox.ValueMember = nameof(Models.Country.Id);
				countriesListBox.DisplayMember = nameof(Models.Country.DisplayName);

				//countriesListBox.DataSource = countries;
				// **************************************************
				// /Solution (3)
				// **************************************************
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
			}
			finally
			{
				if (databaseContext != null)
				{
					databaseContext.Dispose();
					//databaseContext = null;
				}
			}
		}

		private void DeleteAllCountriesButton_Click(object sender, System.EventArgs e)
		{
			Models.DatabaseContext databaseContext = null;

			try
			{
				databaseContext =
					new Models.DatabaseContext();

				// Solution (1)
				//databaseContext.Countries
				//	.Load();

				//databaseContext.Countries.Local.Clear();

				//databaseContext.SaveChanges();
				// /Solution (1)

				// Solution (2)
				//var countries =
				//	databaseContext.Countries
				//	.ToList()
				//	;

				//foreach (Models.Country currentCountry in countries)
				//{
				//	databaseContext.Countries.Remove(currentCountry);
				//}

				//databaseContext.SaveChanges();
				// /Solution (2)

				// Solution (3)
				//string query =
				//	"DELETE FROM Countries";

				//int affectedRows =
				//	databaseContext.Database
				//	.ExecuteSqlCommand(query);
				// /Solution (3)

				// Solution (4)
				// روش خطرناک
				// Sql Injection
				//string query =
				//	"DELETE FROM Countries WHERE CountryName = '" + countryNameTextBox.Text + "'";

				//countryNameTextBox.Text = "';DROP DATABASE;SELECT * FROM COUNTRIES WHERE NAME ='";
				//	"DELETE FROM Countries WHERE CountryName = '';DROP DATABASE;SELECT * FROM COUNTRIES WHERE NAME =''";

				//int affectedRows =
				//	databaseContext.Database
				//	.ExecuteSqlCommand(query);
				// /Solution (4)

				// Solution (5)
				// روش خطرناک
				// Sql Injection
				//string query =
				//	string.Format("DELETE FROM Countries WHERE CountryName = '{0}'",
				//	countryNameTextBox.Text);

				//int affectedRows =
				//	databaseContext.Database
				//	.ExecuteSqlCommand(query);
				// /Solution (5)

				// Solution (6)
				// روش خطرناک
				// Sql Injection
				//string query =
				//	$"DELETE FROM Countries WHERE CountryName = '{ countryNameTextBox.Text }'";

				//int affectedRows =
				//	databaseContext.Database
				//	.ExecuteSqlCommand(query);
				// /Solution (6)

				// Solution (7)
				// Note: Sql Injection Free!
				// Note: Add [System.Data] in references
				//string query =
				//	"DELETE FROM Countries WHERE CountryName = @CName";

				//System.Data.SqlClient.SqlParameter sqlParameter =
				//	new System.Data.SqlClient.SqlParameter("CName", countryNameTextBox.Text);

				//int affectedRows =
				//	databaseContext.Database
				//	.ExecuteSqlCommand(query, sqlParameter);
				// /Solution (7)

				// Solution (8)
				// Note: Add [System.Data] in references
				//string query =
				//	"DELETE FROM Countries WHERE Id >= @FromCode AND Id <= @ToCode AND CountryName LIKE '%@CName%'";

				//System.Data.SqlClient.SqlParameter sqlParameter1 =
				//	new System.Data.SqlClient.SqlParameter("CName", countryNameTextBox.Text);

				//System.Data.SqlClient.SqlParameter sqlParameter2 =
				//	new System.Data.SqlClient.SqlParameter("FromCode", fromCountryCodeTextBox.Text);

				//System.Data.SqlClient.SqlParameter sqlParameter3 =
				//	new System.Data.SqlClient.SqlParameter("ToCode", toCountryCodeTextBox.Text);

				//System.Data.SqlClient.SqlParameter sqlParameter4 = new System.Data.SqlClient.SqlParameter();

				//sqlParameter4.ParameterName = "Output1";
				//sqlParameter4.Direction = System.Data.ParameterDirection.Output;

				//System.Data.SqlClient.SqlParameter sqlParameter5 = new System.Data.SqlClient.SqlParameter();

				//sqlParameter5.Value = "Some Value!";
				//sqlParameter5.ParameterName = "InputOutput1";
				//sqlParameter5.Direction = System.Data.ParameterDirection.InputOutput;

				// در دستور ذیل، ترتیب نوشتن پارامترها اهمیتی ندارد
				//int affectedRows =
				//	databaseContext.Database
				//	.ExecuteSqlCommand(query, sqlParameter3, sqlParameter1, sqlParameter2, sqlParameter4, sqlParameter5);
				// /Solution (8)

				// Solution (9)
				// Note: Add [System.Data] in references
				//string query =
				//	"DELETE FROM Countries WHERE Id >= @FromCode AND Id <= @ToCode AND CountryName = @CName";

				//System.Data.IDbDataParameter parameter1 =
				//	Models.ProviderFactory.GetParameter("CName", txtCountryName.Text);

				//System.Data.IDbDataParameter parameter2 =
				//	Models.ProviderFactory.GetParameter("FromCode", txtFromCountryCode.Text);

				//System.Data.IDbDataParameter parameter3 =
				//	Models.ProviderFactory.GetParameter("ToCode", txtToCountryCode.Text);

				//int affectedRows =
				//	databaseContext.Database
				//	.ExecuteSqlCommand(query, parameter3, parameter1, parameter2);
				// /Solution (9)

				// LINQ آموزش فلسفه
				//var countries =
				//	databaseContext.Countries
				//	.Where(current => current.Name.Contains("A"))
				//	.OrderBy(current => current.Name)
				//	.ToList()
				//	;

				//System.IO.DirectoryInfo directoryInfo =
				//	new System.IO.DirectoryInfo("C:\\Windows");

				//var varFiles =
				//	directoryInfo.GetFiles()
				//	.Where(current => current.Name.Contains("A"))
				//	.OrderBy(current => current.Name)
				//	.ToList()
				//	;
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
			}
			finally
			{
				if (databaseContext != null)
				{
					databaseContext.Dispose();
					//databaseContext = null;
				}
			}
		}

		private void DeleteACountryByNameButton_Click(object sender, System.EventArgs e)
		{
			Models.DatabaseContext databaseContext = null;

			try
			{
				databaseContext =
					new Models.DatabaseContext();

				// **************************************************
				// Solution (1) (فاجعه)
				// **************************************************
				//Models.Country country =
				//	databaseContext.Countries
				//	.ToList()
				//	.Where(current => current.Name == countryNameTextBox.Text)
				//	.FirstOrDefault();
				// **************************************************
				// /Solution (1) (فاجعه)
				// **************************************************

				// **************************************************
				// Solution (2)
				// **************************************************
				//Models.Country country =
				//	databaseContext.Countries
				//	.Where(current => current.Name == txtCountryName.Text)
				//	.FirstOrDefault();
				// **************************************************
				// /Solution (2)
				// **************************************************

				// **************************************************
				// Solution (3)
				// **************************************************
				Models.Country foundedCountry =
					databaseContext.Countries
					.Where(current => string.Compare(current.Name, countryNameTextBox.Text, true) == 0)
					.FirstOrDefault();
				// **************************************************
				// /Solution (3)
				// **************************************************

				if (foundedCountry == null)
				{
					System.Windows.Forms.MessageBox
						.Show("There is not any country with this name!");
				}
				else
				{
					databaseContext.Countries.Remove(foundedCountry);

					databaseContext.SaveChanges();

					System.Windows.Forms.MessageBox
						.Show("The country deleted succefully!");
				}
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
			}
			finally
			{
				if (databaseContext != null)
				{
					databaseContext.Dispose();
					//databaseContext = null;
				}
			}
		}

		private void CheckStatesButton_Click(object sender, System.EventArgs e)
		{
			Models.DatabaseContext databaseContext = new Models.DatabaseContext();

			// **************************************************
			databaseContext.Countries
				.OrderBy(current => current.Code)
				.Load();
			// **************************************************

			// **************************************************
			//System.Collections.ObjectModel.ObservableCollection<Models.Country>
			//	localCountries = databaseContext.Countries.Local;
			// **************************************************

			// **************************************************
			var localCountries =
				databaseContext.Countries.Local;
			// **************************************************

			// **************************************************
			System.Windows.Forms.MessageBox
				.Show("(1) Count: " + localCountries.Count);
			// **************************************************

			// Delete
			// **************************************************
			Models.Country deletedCountry = localCountries[0];

			System.Windows.Forms.MessageBox.Show
				("(2) " + databaseContext.Entry(deletedCountry).State.ToString());

			localCountries.RemoveAt(0);

			System.Windows.Forms.MessageBox.Show
				("(3) " + databaseContext.Entry(deletedCountry).State.ToString());
			// **************************************************

			// **************************************************
			System.Windows.Forms.MessageBox
				.Show("(4) Count: " + localCountries.Count);
			// **************************************************

			// Add New
			// **************************************************
			Models.Country newCountry = new Models.Country();

			newCountry.Name = "Some Added Country";

			System.Windows.Forms.MessageBox.Show
				("(5) " + databaseContext.Entry(newCountry).State.ToString());

			localCountries.Add(newCountry);

			System.Windows.Forms.MessageBox.Show
				("(6) " + databaseContext.Entry(newCountry).State.ToString());
			// **************************************************

			// Edit
			// **************************************************
			Models.Country editedCountry = localCountries[0];

			System.Windows.Forms.MessageBox.Show
				("(7) " + databaseContext.Entry(editedCountry).State.ToString());

			string currentValue = editedCountry.Name;
			editedCountry.Name = currentValue;

			System.Windows.Forms.MessageBox.Show
				("(8) " + databaseContext.Entry(editedCountry).State.ToString());

			editedCountry.Name = "Edited Country";

			System.Windows.Forms.MessageBox.Show
				("(9) " + databaseContext.Entry(editedCountry).State.ToString());

			editedCountry.Name = currentValue;

			System.Windows.Forms.MessageBox.Show
				("(10) " + databaseContext.Entry(editedCountry).State.ToString());
			// **************************************************

			// **************************************************
			//for (int index = 0; index <= localCountries.Count - 1; index++)
			//{
			//	System.Windows.Forms.MessageBox.Show(index.ToString() + ") - " +
			//		databaseContext.Entry(localCountries[index]).State.ToString());
			//}
			// **************************************************

			// یک رکوردی را که از بانک اطلاعاتی دریافت کرده‌ایم را
			// چند بار یک یا چند فیلد آنرا تغییر داده
			// و پس از آن آنرا از مجموعه حذف می‌کنیم
			// وضعیت آن رکورد چه خواهد بود؟

			// یک رکورد ایجاد می‌کنیم
			// و به مجموعه اضافه می‌کنیم
			// تعدادی از پراپرتی‌های آنرا تغییر می‌دهیم 
			// مجددا با دستور
			// Remove یا RemoveAt
			// همان رکورد را حذف می‌کنیم
			// وضعیت آن رکورد چه خواهد بود؟

			Models.Country theNewCountry = new Models.Country();

			databaseContext.Countries.Add(theNewCountry);

			databaseContext.Countries.Remove(theNewCountry);

			// theNewCountry.State ?
		}

		private void AddNewCountryButton_Click(object sender, System.EventArgs e)
		{
			Models.DatabaseContext databaseContext = null;

			try
			{
				databaseContext =
					new Models.DatabaseContext();

				// **************************************************
				// Create:
				// **************************************************

				// Solution (1)
				//Models.Country country = new Models.Country();

				//country.Name = "New Country";

				//databaseContext.Countries.Add(country);
				// /Solution (1)

				// Solution (2)
				Models.Country country = new Models.Country();

				country.Name = "New Country";

				databaseContext.Entry(country).State =
					System.Data.Entity.EntityState.Added;
				// /Solution (2)

				databaseContext.SaveChanges();

				System.Guid id = System.Guid.NewGuid();

				// **************************************************
				// Modify:
				// **************************************************

				// Solution (1)
				//Models.Country theCountry =
				//	databaseContext.Countries
				//	.Where(current => current.Id == sId)
				//	.FirstOrDefault();

				//theCountry.Name = "Something Else...";
				// /Solution (1)

				// Solution (2)
				Models.Country theCountry = new Models.Country();

				theCountry.Id = id; // مهم
				theCountry.Name = "Something Else...";

				databaseContext.Entry(theCountry).State =
					System.Data.Entity.EntityState.Modified;
				// /Solution (2)

				// **************************************************
				// Modify: (Just Some Fields Value)
				// **************************************************

				// خیلی جالبه
				databaseContext.Entry(theCountry).Property(current => current.Name).IsModified = true;

				// **************************************************
				// Delete:
				// **************************************************

				// Solution (1)
				//Models.Country theCountry =
				//	databaseContext.Countries
				//	.Where(current => current.Id == sId)
				//	.FirstOrDefault();

				//databaseContext.Countries.Remove(theCountry);
				// /Solution (1)

				// Solution (2)
				Models.Country myCountry = new Models.Country();

				theCountry.Id = id; // مهم

				databaseContext.Entry(theCountry).State =
					System.Data.Entity.EntityState.Deleted;
				// /Solution (2)
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
			}
			finally
			{
				if (databaseContext != null)
				{
					databaseContext.Dispose();
					//databaseContext = null;
				}
			}
		}
	}
}
