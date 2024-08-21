/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Dlc.V20210125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CopyDLCTableRequest : AbstractModel
    {
        
        /// <summary>
        /// Description of the source data table name
        /// </summary>
        [JsonProperty("SourceData")]
        public DMSSourceDatabaseInfo[] SourceData{ get; set; }

        /// <summary>
        /// Target database name
        /// </summary>
        [JsonProperty("DestinationDatabaseName")]
        public string DestinationDatabaseName{ get; set; }

        /// <summary>
        /// Target data table name
        /// </summary>
        [JsonProperty("DestinationTableName")]
        public string DestinationTableName{ get; set; }

        /// <summary>
        /// Engine name
        /// </summary>
        [JsonProperty("DataEngineName")]
        public string DataEngineName{ get; set; }

        /// <summary>
        /// Whether to create a new table
        /// </summary>
        [JsonProperty("IsCreateTable")]
        public bool? IsCreateTable{ get; set; }

        /// <summary>
        /// Catalog name
        /// </summary>
        [JsonProperty("Catalog")]
        public string Catalog{ get; set; }

        /// <summary>
        /// Resource group name
        /// </summary>
        [JsonProperty("ResourceGroupName")]
        public string ResourceGroupName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "SourceData.", this.SourceData);
            this.SetParamSimple(map, prefix + "DestinationDatabaseName", this.DestinationDatabaseName);
            this.SetParamSimple(map, prefix + "DestinationTableName", this.DestinationTableName);
            this.SetParamSimple(map, prefix + "DataEngineName", this.DataEngineName);
            this.SetParamSimple(map, prefix + "IsCreateTable", this.IsCreateTable);
            this.SetParamSimple(map, prefix + "Catalog", this.Catalog);
            this.SetParamSimple(map, prefix + "ResourceGroupName", this.ResourceGroupName);
        }
    }
}

