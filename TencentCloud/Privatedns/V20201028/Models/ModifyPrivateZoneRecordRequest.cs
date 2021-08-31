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

namespace TencentCloud.Privatedns.V20201028.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyPrivateZoneRecordRequest : AbstractModel
    {
        
        /// <summary>
        /// Private domain ID
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// Record ID
        /// </summary>
        [JsonProperty("RecordId")]
        public string RecordId{ get; set; }

        /// <summary>
        /// Record type. Valid values: "A", "AAAA", "CNAME", "MX", "TXT", "PTR"
        /// </summary>
        [JsonProperty("RecordType")]
        public string RecordType{ get; set; }

        /// <summary>
        /// Subdomain, such as "www", "m", and "@"
        /// </summary>
        [JsonProperty("SubDomain")]
        public string SubDomain{ get; set; }

        /// <summary>
        /// Record value, such as IP: 192.168.10.2, CNAME: cname.qcloud.com., and MX: mail.qcloud.com.
        /// </summary>
        [JsonProperty("RecordValue")]
        public string RecordValue{ get; set; }

        /// <summary>
        /// Record weight. Value range: 1–100
        /// </summary>
        [JsonProperty("Weight")]
        public long? Weight{ get; set; }

        /// <summary>
        /// MX priority, which is required when the record type is MX. Valid values: 5, 10, 15, 20, 30, 40, 50
        /// </summary>
        [JsonProperty("MX")]
        public long? MX{ get; set; }

        /// <summary>
        /// Record cache time. The smaller the value, the faster the record will take effect. Value range: 1–86400s. Default value: 600
        /// </summary>
        [JsonProperty("TTL")]
        public long? TTL{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "RecordId", this.RecordId);
            this.SetParamSimple(map, prefix + "RecordType", this.RecordType);
            this.SetParamSimple(map, prefix + "SubDomain", this.SubDomain);
            this.SetParamSimple(map, prefix + "RecordValue", this.RecordValue);
            this.SetParamSimple(map, prefix + "Weight", this.Weight);
            this.SetParamSimple(map, prefix + "MX", this.MX);
            this.SetParamSimple(map, prefix + "TTL", this.TTL);
        }
    }
}

