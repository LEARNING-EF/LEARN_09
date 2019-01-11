namespace Models
{
	public class Country : object
	{
		public Country() : base()
		{
			Id = System.Guid.NewGuid();
		}

		public System.Guid Id { get; set; }

		public int Code { get; set; }

		public string Name { get; set; }

		public string DisplayName
		{
			get
			{
				string result =
					$"{ Code } - { Name }";

				return result;
			}
		}
	}
}
