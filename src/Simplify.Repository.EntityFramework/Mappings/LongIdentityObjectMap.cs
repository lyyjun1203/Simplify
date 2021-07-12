using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Simplify.Repository.EntityFramework.Mappings
{
	/// <summary>
	/// Long identity object mapping
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public abstract class LongIdentityObjectMap<T> : IEntityTypeConfiguration<T>
		where T : class, ILongIdentityObject
	{
		/// <summary>
		/// Configures the entity of type <typeparamref name="T" />.
		/// </summary>
		/// <param name="builder">The builder to be used to configure the entity type.</param>
		public void Configure(EntityTypeBuilder<T> builder)
		{
			builder.HasKey(x => x.ID);

			ConfigureEntity(builder);
		}

		/// <summary>
		/// Adds entity additional configurations.
		/// </summary>
		/// <param name="builder">The builder.</param>
		protected abstract void ConfigureEntity(EntityTypeBuilder<T> builder);
	}
}