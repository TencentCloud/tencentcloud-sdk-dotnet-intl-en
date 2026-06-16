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

namespace TencentCloud.Bi.V20220105.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeSourceFieldListRequest : AbstractModel
    {
        
        /// <summary>
        /// data source Id
        /// </summary>
        [JsonProperty("DataSourceId")]
        public long? DataSourceId{ get; set; }

        /// <summary>
        /// Table name
        /// </summary>
        [JsonProperty("TableName")]
        public string TableName{ get; set; }

        /// <summary>
        /// sql content
        /// </summary>
        [JsonProperty("Sql")]
        public string Sql{ get; set; }

        /// <summary>
        /// Project ID.
        /// </summary>
        [JsonProperty("ProjectId")]
        public ulong? ProjectId{ get; set; }

        /// <summary>
        /// whether
        /// </summary>
        [JsonProperty("AsyncRequest")]
        public bool? AsyncRequest{ get; set; }

        /// <summary>
        /// async transaction id
        /// </summary>
        [JsonProperty("TranId")]
        public string TranId{ get; set; }

        /// <summary>
        /// 11
        /// </summary>
        [JsonProperty("ParamList")]
        public ParamCreateDTO[] ParamList{ get; set; }

        /// <summary>
        /// DLC extension parameter
        /// </summary>
        [JsonProperty("DlcExtInfo")]
        public string DlcExtInfo{ get; set; }

        /// <summary>
        /// Query database required or not
        /// </summary>
        [JsonProperty("QueryDbData")]
        public string QueryDbData{ get; set; }

        /// <summary>
        /// Data table Id
        /// </summary>
        [JsonProperty("TableId")]
        public string TableId{ get; set; }

        /// <summary>
        /// The backend provides a dictionary: table type, 1. database table creation, 2. SQL table creation, 3. Excel upload, 4. API connection, 5. Tencent documentation, 6. cloud database, 7. manually enter, 8. join query.
        /// </summary>
        [JsonProperty("TableType")]
        public ulong? TableType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DataSourceId", this.DataSourceId);
            this.SetParamSimple(map, prefix + "TableName", this.TableName);
            this.SetParamSimple(map, prefix + "Sql", this.Sql);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "AsyncRequest", this.AsyncRequest);
            this.SetParamSimple(map, prefix + "TranId", this.TranId);
            this.SetParamArrayObj(map, prefix + "ParamList.", this.ParamList);
            this.SetParamSimple(map, prefix + "DlcExtInfo", this.DlcExtInfo);
            this.SetParamSimple(map, prefix + "QueryDbData", this.QueryDbData);
            this.SetParamSimple(map, prefix + "TableId", this.TableId);
            this.SetParamSimple(map, prefix + "TableType", this.TableType);
        }
    }
}

