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

namespace TencentCloud.Cynosdb.V20190107.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SaleZone : AbstractModel
    {
        
        /// <summary>
        /// AZ name
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// Numeric ID of an AZ
        /// </summary>
        [JsonProperty("ZoneId")]
        public long? ZoneId{ get; set; }

        /// <summary>
        /// AZ name
        /// </summary>
        [JsonProperty("ZoneZh")]
        public string ZoneZh{ get; set; }

        /// <summary>
        /// Whether serverless cluster is supported. Valid values: <br>
        /// `0`: No<br>
        /// `1`: Yes
        /// </summary>
        [JsonProperty("IsSupportServerless")]
        public long? IsSupportServerless{ get; set; }

        /// <summary>
        /// Whether standard cluster is supported. Valid values: <br>
        /// `0`: No<br>
        /// `1`: Yes
        /// </summary>
        [JsonProperty("IsSupportNormal")]
        public long? IsSupportNormal{ get; set; }

        /// <summary>
        /// Physical zone
        /// </summary>
        [JsonProperty("PhysicalZone")]
        public string PhysicalZone{ get; set; }

        /// <summary>
        /// Whether the user has AZ permission
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("HasPermission")]
        public bool? HasPermission{ get; set; }

        /// <summary>
        /// Whether it is a full-linkage RDMA AZ.
        /// </summary>
        [JsonProperty("IsWholeRdmaZone")]
        public string IsWholeRdmaZone{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "ZoneZh", this.ZoneZh);
            this.SetParamSimple(map, prefix + "IsSupportServerless", this.IsSupportServerless);
            this.SetParamSimple(map, prefix + "IsSupportNormal", this.IsSupportNormal);
            this.SetParamSimple(map, prefix + "PhysicalZone", this.PhysicalZone);
            this.SetParamSimple(map, prefix + "HasPermission", this.HasPermission);
            this.SetParamSimple(map, prefix + "IsWholeRdmaZone", this.IsWholeRdmaZone);
        }
    }
}

