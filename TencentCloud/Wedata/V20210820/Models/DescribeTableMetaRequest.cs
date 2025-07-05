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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeTableMetaRequest : AbstractModel
    {
        
        /// <summary>
        /// Unique Table ID
        /// </summary>
        [JsonProperty("TableId")]
        public string TableId{ get; set; }

        /// <summary>
        /// Query conditions by Name
        /// </summary>
        [JsonProperty("TableNameFilter")]
        public TableNameFilter TableNameFilter{ get; set; }

        /// <summary>
        /// Query condition type: 0 by ID, 1 by Name, default is 0
        /// </summary>
        [JsonProperty("TableFilterType")]
        public ulong? TableFilterType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TableId", this.TableId);
            this.SetParamObj(map, prefix + "TableNameFilter.", this.TableNameFilter);
            this.SetParamSimple(map, prefix + "TableFilterType", this.TableFilterType);
        }
    }
}

