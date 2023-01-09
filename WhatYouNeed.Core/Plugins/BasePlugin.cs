using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appli.Core.Plugins
{
    public abstract class BasePlugin : IPlugin
    {
        /// <summary>
        /// Gets or sets the plugin descriptor
        /// </summary>
        public virtual PluginDescriptor PluginDescriptor { get; set; }

        /// <summary>
        /// Install plugin
        /// </summary>
        public virtual void Install()
        {
            //PluginManager.MarkPluginAsInstalled(this.PluginDescriptor.SystemName);
            throw new NotImplementedException("Plugin Base et Manager Not implemented");
        }

        /// <summary>
        /// Uninstall plugin
        /// </summary>
        public virtual void Uninstall()
        {
            //PluginManager.MarkPluginAsUninstalled(this.PluginDescriptor.SystemName);
            throw new NotImplementedException("Plugin Base et Manager Not implemented");
        }

        /// <summary>
        /// Enable/Disable plugin
        /// </summary>
        /// <param name="enable"></param>
        public virtual void Enable(bool enable)
        {
            //PluginManager.MarkPluginAsEnabled(this.PluginDescriptor.SystemName, enable);
            throw new NotImplementedException("Plugin Base et Manager Not implemented");
        }
    }
}
