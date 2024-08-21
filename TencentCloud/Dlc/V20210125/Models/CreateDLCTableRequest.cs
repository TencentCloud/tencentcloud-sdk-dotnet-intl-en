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

    public class CreateDLCTableRequest : AbstractModel
    {
        
        /// <summary>
        /// Data table configuration information
        /// </summary>
        [JsonProperty("TableBaseInfo")]
        public TableBaseInfo TableBaseInfo{ get; set; }

        /// <summary>
        /// Table type
        /// </summary>
        [JsonProperty("TableType")]
        public string TableType{ get; set; }

        /// <summary>
        /// Data table column information
        /// </summary>
        [JsonProperty("Columns")]
        public TColumn[] Columns{ get; set; }

        /// <summary>
        /// Data table partition information
        /// </summary>
        [JsonProperty("Partitions")]
        public TPartition[] Partitions{ get; set; }

        /// <summary>
        /// Data table attribute information
        /// </summary>
        [JsonProperty("Properties")]
        public Property[] Properties{ get; set; }

        /// <summary>
        /// External table configuration information
        /// </summary>
        [JsonProperty("ExternalDataConfiguration")]
        public ExternalDataConfiguration ExternalDataConfiguration{ get; set; }

        /// <summary>
        /// Engine name
        /// </summary>
        [JsonProperty("DataEngineName")]
        public string DataEngineName{ get; set; }

        /// <summary>
        /// Resource group name
        /// </summary>
        [JsonProperty("ResourceGroupname")]
        public string ResourceGroupname{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "TableBaseInfo.", this.TableBaseInfo);
            this.SetParamSimple(map, prefix + "TableType", this.TableType);
            this.SetParamArrayObj(map, prefix + "Columns.", this.Columns);
            this.SetParamArrayObj(map, prefix + "Partitions.", this.Partitions);
            this.SetParamArrayObj(map, prefix + "Properties.", this.Properties);
            this.SetParamObj(map, prefix + "ExternalDataConfiguration.", this.ExternalDataConfiguration);
            this.SetParamSimple(map, prefix + "DataEngineName", this.DataEngineName);
            this.SetParamSimple(map, prefix + "ResourceGroupname", this.ResourceGroupname);
        }
    }
}

