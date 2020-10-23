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

namespace TencentCloud.Sqlserver.V20180328.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ZoneInfo : AbstractModel
    {
        
        /// <summary>
        /// AZ ID in the format of ap-guangzhou-1 (i.e., Guangzhou Zone 1)
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// AZ name
        /// </summary>
        [JsonProperty("ZoneName")]
        public string ZoneName{ get; set; }

        /// <summary>
        /// Numeric ID of AZ
        /// </summary>
        [JsonProperty("ZoneId")]
        public long? ZoneId{ get; set; }

        /// <summary>
        /// ID of specification purchasable in this AZ, which, together with the returned value of the `DescribeProductConfig` API, can be used to find out the specifications currently purchasable in the AZ
        /// </summary>
        [JsonProperty("SpecId")]
        public long? SpecId{ get; set; }

        /// <summary>
        /// Information of database versions purchasable under the current AZ and specification. Valid values: 2008R2 (SQL Server 2008 Enterprise), 2012SP3 (SQL Server 2012 Enterprise), 2016SP1 (SQL Server 2016 Enterprise), 201602 (SQL Server 2016 Standard), 2017 (SQL Server 2017 Enterprise)
        /// </summary>
        [JsonProperty("Version")]
        public string Version{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "ZoneName", this.ZoneName);
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "SpecId", this.SpecId);
            this.SetParamSimple(map, prefix + "Version", this.Version);
        }
    }
}

