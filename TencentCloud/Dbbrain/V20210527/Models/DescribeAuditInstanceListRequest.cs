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

namespace TencentCloud.Dbbrain.V20210527.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeAuditInstanceListRequest : AbstractModel
    {
        
        /// <summary>
        /// Service type. Valid values: `dcdb` (TDSQL for MySQL), `mariadb` (TencentDB for MariaDB).
        /// </summary>
        [JsonProperty("Product")]
        public string Product{ get; set; }

        /// <summary>
        /// Use the value of `Product` for this parameter, such as `dcdb` and `mariadb`.
        /// </summary>
        [JsonProperty("NodeRequestType")]
        public string NodeRequestType{ get; set; }

        /// <summary>
        /// Audit status. Valid values: `0` (Not enabled), `1` (Enabled). Default value: `0`.
        /// </summary>
        [JsonProperty("AuditSwitch")]
        public long? AuditSwitch{ get; set; }

        /// <summary>
        /// The offset. Default value: `0`.
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// The number of queried items. Default value: `20`. Max value: `100`.
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// Filters for querying instances
        /// </summary>
        [JsonProperty("Filters")]
        public AuditInstanceFilter[] Filters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Product", this.Product);
            this.SetParamSimple(map, prefix + "NodeRequestType", this.NodeRequestType);
            this.SetParamSimple(map, prefix + "AuditSwitch", this.AuditSwitch);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
        }
    }
}

