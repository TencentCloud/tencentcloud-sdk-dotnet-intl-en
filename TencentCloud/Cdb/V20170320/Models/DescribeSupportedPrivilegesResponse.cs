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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeSupportedPrivilegesResponse : AbstractModel
    {
        
        /// <summary>
        /// Global permissions supported by the instance
        /// </summary>
        [JsonProperty("GlobalSupportedPrivileges")]
        public string[] GlobalSupportedPrivileges{ get; set; }

        /// <summary>
        /// Database permissions supported by the instance.
        /// </summary>
        [JsonProperty("DatabaseSupportedPrivileges")]
        public string[] DatabaseSupportedPrivileges{ get; set; }

        /// <summary>
        /// Table permissions supported by the instance.
        /// </summary>
        [JsonProperty("TableSupportedPrivileges")]
        public string[] TableSupportedPrivileges{ get; set; }

        /// <summary>
        /// Column permissions supported by the instance.
        /// </summary>
        [JsonProperty("ColumnSupportedPrivileges")]
        public string[] ColumnSupportedPrivileges{ get; set; }

        /// <summary>
        /// The unique request ID, which is returned for each request. RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "GlobalSupportedPrivileges.", this.GlobalSupportedPrivileges);
            this.SetParamArraySimple(map, prefix + "DatabaseSupportedPrivileges.", this.DatabaseSupportedPrivileges);
            this.SetParamArraySimple(map, prefix + "TableSupportedPrivileges.", this.TableSupportedPrivileges);
            this.SetParamArraySimple(map, prefix + "ColumnSupportedPrivileges.", this.ColumnSupportedPrivileges);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

