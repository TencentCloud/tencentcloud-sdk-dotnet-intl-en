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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class OriginRecord : AbstractModel
    {
        
        /// <summary>
        /// The origin record value, which can be an IPv4/IPv6 address or a domain name.
        /// </summary>
        [JsonProperty("Record")]
        public string Record{ get; set; }

        /// <summary>
        /// The origin type. Values:
        /// <li>`IP_DOMAIN`: IPv4/IPv6 address or domain name</li>
        /// <li>`COS`: COS bucket address</li>
        /// <li>`AWS_S3`: AWS S3 bucket address
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// The origin record ID.
        /// </summary>
        [JsonProperty("RecordId")]
        public string RecordId{ get; set; }

        /// <summary>
        /// [Origin server weight]: a parameter used to control traffic allocation priority, value ranges from 0 to 100 (integer): <li>empty value: no weight is set, and the system schedules traffic based on the default policy;</li> <li>0 value: explicitly set the weight to 0, and traffic will not be assigned to this origin server. note: make sure at least one origin server has a weight value above 0;</li> <li>normal value: the larger the value, the more traffic is assigned;</li>.
        /// Note: This field may return null, which indicates a failure to obtain a valid value.
        /// </summary>
        [JsonProperty("Weight")]
        public ulong? Weight{ get; set; }

        /// <summary>
        /// Whether to enable private authentication. It is valid when `OriginType=COS/AWS_S3`. Values:
        /// <li>`true`: Yes.</li>
        /// <li>`false`: No.</li>Default: `false`.
        /// </summary>
        [JsonProperty("Private")]
        public bool? Private{ get; set; }

        /// <summary>
        /// Private authentication parameters. This field is valid when `Private=true`.
        /// </summary>
        [JsonProperty("PrivateParameters")]
        public PrivateParameter[] PrivateParameters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Record", this.Record);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "RecordId", this.RecordId);
            this.SetParamSimple(map, prefix + "Weight", this.Weight);
            this.SetParamSimple(map, prefix + "Private", this.Private);
            this.SetParamArrayObj(map, prefix + "PrivateParameters.", this.PrivateParameters);
        }
    }
}

