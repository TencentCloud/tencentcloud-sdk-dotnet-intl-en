/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Dts.V20211206.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Database : AbstractModel
    {
        
        /// <summary>
        /// <p>Database name for migration or synchronization. This item is required when ObjectMode is Partial.</p>
        /// </summary>
        [JsonProperty("DbName")]
        public string DbName{ get; set; }

        /// <summary>
        /// <p>The name of the migrated or synchronized database is identical to that of the source database by default.</p>
        /// </summary>
        [JsonProperty("NewDbName")]
        public string NewDbName{ get; set; }

        /// <summary>
        /// <p>DB selection mode: All (for all objects under the current object), Partial (partial objects). This item is required when Mode is Partial. Note that synchronization of advanced objects is independent of this value. If you sync entire database, it should be All here.</p>
        /// </summary>
        [JsonProperty("DbMode")]
        public string DbMode{ get; set; }

        /// <summary>
        /// <p>schema for migration or synchronization</p>
        /// </summary>
        [JsonProperty("SchemaName")]
        public string SchemaName{ get; set; }

        /// <summary>
        /// <p>schema name after migration or synchronization</p>
        /// </summary>
        [JsonProperty("NewSchemaName")]
        public string NewSchemaName{ get; set; }

        /// <summary>
        /// <p>schema Selection Mode, pg and sqlserver require the use of</p><p>Enumeration value:</p><ul><li>All: All objects under the current object</li><li>Partial: Partial objects</li></ul>
        /// </summary>
        [JsonProperty("SchemaMode")]
        public string SchemaMode{ get; set; }

        /// <summary>
        /// <p>Schema selection mode: All (for all objects under the current object), Partial (partial objects). This item is required when DBMode is Partial. If you sync entire database, it should be All here.</p>
        /// </summary>
        [JsonProperty("TableMode")]
        public string TableMode{ get; set; }

        /// <summary>
        /// <p>Table diagram object set. This item needs to be filled in when TableMode is Partial.</p>
        /// </summary>
        [JsonProperty("Tables")]
        public Table[] Tables{ get; set; }

        /// <summary>
        /// <p>View selection mode: All indicates all view objects under the current object, Partial indicates partial view objects. If you sync entire database, it should be All here.</p>
        /// </summary>
        [JsonProperty("ViewMode")]
        public string ViewMode{ get; set; }

        /// <summary>
        /// <p>View object set. When ViewMode is Partial, this item requires filling in.</p>
        /// </summary>
        [JsonProperty("Views")]
        public View[] Views{ get; set; }

        /// <summary>
        /// <p>Select the sync mode. Partial means part, and All means the entire database. If you want to sync entire database, select All here.</p>
        /// </summary>
        [JsonProperty("FunctionMode")]
        public string FunctionMode{ get; set; }

        /// <summary>
        /// <p>This item needs to be filled in when FunctionMode value is Partial.</p>
        /// </summary>
        [JsonProperty("Functions")]
        public string[] Functions{ get; set; }

        /// <summary>
        /// <p>Select the sync mode. Partial means part, and All means the entire database. If you want to sync entire database, select All here.</p>
        /// </summary>
        [JsonProperty("ProcedureMode")]
        public string ProcedureMode{ get; set; }

        /// <summary>
        /// <p>This item needs to be filled in when the ProcedureMode value is Partial.</p>
        /// </summary>
        [JsonProperty("Procedures")]
        public string[] Procedures{ get; set; }

        /// <summary>
        /// <p>Trigger migration mode, All (all objects under the current object), Partial (partial objects). If syncing the entire database, it should be All here. Data sync does not currently support this advanced object.</p>
        /// </summary>
        [JsonProperty("TriggerMode")]
        public string TriggerMode{ get; set; }

        /// <summary>
        /// <p>When TriggerMode is partial, specify the trigger name to migrate.</p>
        /// </summary>
        [JsonProperty("Triggers")]
        public string[] Triggers{ get; set; }

        /// <summary>
        /// <p>Event migration mode: All (all objects under the current object), Partial (partial objects). If syncing the entire database, it should be All here. This advanced object is not currently supported for data sync.</p>
        /// </summary>
        [JsonProperty("EventMode")]
        public string EventMode{ get; set; }

        /// <summary>
        /// <p>When EventMode is partial, specify the event name to migrate.</p>
        /// </summary>
        [JsonProperty("Events")]
        public string[] Events{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DbName", this.DbName);
            this.SetParamSimple(map, prefix + "NewDbName", this.NewDbName);
            this.SetParamSimple(map, prefix + "DbMode", this.DbMode);
            this.SetParamSimple(map, prefix + "SchemaName", this.SchemaName);
            this.SetParamSimple(map, prefix + "NewSchemaName", this.NewSchemaName);
            this.SetParamSimple(map, prefix + "SchemaMode", this.SchemaMode);
            this.SetParamSimple(map, prefix + "TableMode", this.TableMode);
            this.SetParamArrayObj(map, prefix + "Tables.", this.Tables);
            this.SetParamSimple(map, prefix + "ViewMode", this.ViewMode);
            this.SetParamArrayObj(map, prefix + "Views.", this.Views);
            this.SetParamSimple(map, prefix + "FunctionMode", this.FunctionMode);
            this.SetParamArraySimple(map, prefix + "Functions.", this.Functions);
            this.SetParamSimple(map, prefix + "ProcedureMode", this.ProcedureMode);
            this.SetParamArraySimple(map, prefix + "Procedures.", this.Procedures);
            this.SetParamSimple(map, prefix + "TriggerMode", this.TriggerMode);
            this.SetParamArraySimple(map, prefix + "Triggers.", this.Triggers);
            this.SetParamSimple(map, prefix + "EventMode", this.EventMode);
            this.SetParamArraySimple(map, prefix + "Events.", this.Events);
        }
    }
}

