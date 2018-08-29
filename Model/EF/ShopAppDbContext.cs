namespace Model.EF
{
	using System;
	using System.Data.Entity;
	using System.ComponentModel.DataAnnotations.Schema;
	using System.Linq;

	public partial class ShopAppDbContext : DbContext
	{
		public ShopAppDbContext()
			: base("name=ShopAppDbContext")
		{
		}

		public virtual DbSet<About> Abouts { get; set; }
		public virtual DbSet<Category> Categories { get; set; }
		public virtual DbSet<Contact> Contacts { get; set; }
		public virtual DbSet<content> contents { get; set; }
		public virtual DbSet<ContentTag> ContentTags { get; set; }
		public virtual DbSet<customer> customers { get; set; }
		public virtual DbSet<feedback> feedbacks { get; set; }
		public virtual DbSet<footer> footers { get; set; }
		public virtual DbSet<Menu> Menus { get; set; }
		public virtual DbSet<MenuType> MenuTypes { get; set; }
		public virtual DbSet<ProductCategory> ProductCategories { get; set; }
		public virtual DbSet<product> products { get; set; }
		public virtual DbSet<Slide> Slides { get; set; }
		public virtual DbSet<SystemConfig> SystemConfigs { get; set; }
		public virtual DbSet<tag> tags { get; set; }
		public virtual DbSet<User> Users { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<About>()
				.Property(e => e.MetaTitle)
				.IsUnicode(false);

			modelBuilder.Entity<About>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<About>()
				.Property(e => e.ModifiedBy)
				.IsUnicode(false);

			modelBuilder.Entity<About>()
				.Property(e => e.MetaDescriptions)
				.IsFixedLength();

			modelBuilder.Entity<Category>()
				.Property(e => e.CreatedBy1)
				.IsUnicode(false);

			modelBuilder.Entity<Category>()
				.Property(e => e.ModifiedBy)
				.IsUnicode(false);

			modelBuilder.Entity<Category>()
				.Property(e => e.MetaDescriptions)
				.IsFixedLength();

			modelBuilder.Entity<content>()
				.Property(e => e.MetaTitle)
				.IsUnicode(false);

			modelBuilder.Entity<content>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<content>()
				.Property(e => e.ModifiedBy)
				.IsUnicode(false);

			modelBuilder.Entity<content>()
				.Property(e => e.MetaDescriptions)
				.IsFixedLength();

			modelBuilder.Entity<ContentTag>()
				.Property(e => e.TagID)
				.IsUnicode(false);

			modelBuilder.Entity<customer>()
				.Property(e => e.Name)
				.IsFixedLength();

			modelBuilder.Entity<customer>()
				.Property(e => e.Phone)
				.IsFixedLength();

			modelBuilder.Entity<customer>()
				.Property(e => e.Email)
				.IsFixedLength();

			modelBuilder.Entity<footer>()
				.Property(e => e.ID)
				.IsUnicode(false);

			modelBuilder.Entity<ProductCategory>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<ProductCategory>()
				.Property(e => e.ModifiedBy)
				.IsUnicode(false);

			modelBuilder.Entity<ProductCategory>()
				.Property(e => e.MetaDescriptions)
				.IsFixedLength();

			modelBuilder.Entity<product>()
				.Property(e => e.Code)
				.IsUnicode(false);

			modelBuilder.Entity<product>()
				.Property(e => e.MetaTitle)
				.IsUnicode(false);

			modelBuilder.Entity<product>()
				.Property(e => e.Price)
				.HasPrecision(18, 0);

			modelBuilder.Entity<product>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<product>()
				.Property(e => e.ModifiedBy)
				.IsUnicode(false);

			modelBuilder.Entity<product>()
				.Property(e => e.MetaDescriptions)
				.IsFixedLength();

			modelBuilder.Entity<Slide>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<Slide>()
				.Property(e => e.ModifiedBy)
				.IsUnicode(false);

			modelBuilder.Entity<SystemConfig>()
				.Property(e => e.ID)
				.IsUnicode(false);

			modelBuilder.Entity<tag>()
				.Property(e => e.ID)
				.IsUnicode(false);

			modelBuilder.Entity<User>()
				.Property(e => e.Username)
				.IsUnicode(false);

			modelBuilder.Entity<User>()
				.Property(e => e.Password)
				.IsUnicode(false);
		}
	}
}
