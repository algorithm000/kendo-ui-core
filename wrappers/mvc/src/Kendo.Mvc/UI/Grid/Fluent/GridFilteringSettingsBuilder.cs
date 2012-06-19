namespace Kendo.Mvc.UI.Fluent
{
    using System;
    using Infrastructure;

    /// <summary>
    /// Defines the fluent interface for configuring <see cref="Grid{T}.Filterable"/>.
    /// </summary>
    public class GridFilteringSettingsBuilder<TModel>  : IHideObjectMembers where TModel : class
    {
        private readonly GridFilterableSettings settings;

        /// <summary>
        /// Initializes a new instance of the <see cref="GridFilterableSettings"/> class.
        /// </summary>
        /// <param name="settings">The settings.</param>
        public GridFilteringSettingsBuilder(GridFilterableSettings settings)
        {
            this.settings = settings;
        }

        /// <summary>
        /// Enables or disables filtering
        /// </summary>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().Grid(Model)
        ///             .Name("Grid")
        ///             .Filterable(filtering => filtering.Enabled((bool)ViewData["enableFiltering"]))
        /// %&gt;
        /// </code>
        /// </example>
        /// <remarks>
        /// The Enabled method is useful when you need to enable filtering based on certain conditions.
        /// </remarks>
        public virtual GridFilteringSettingsBuilder<TModel> Enabled(bool value)
        {
            settings.Enabled = value;

            return this;
        }        

        public virtual GridFilteringSettingsBuilder<TModel> ShowOrOption(bool value)
        {
            settings.Extra = value;
            settings.Enabled = true;
            return this;
        }

        public virtual GridFilteringSettingsBuilder<TModel> ShowOrOption()
        {
            settings.Extra = true;
            settings.Enabled = true;
            return this;
        }
    }
}