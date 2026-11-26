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
        /// Origin server record value, excluding port information. It can be an IPv4 address, IPv6 address, or domain name format.
        /// </summary>
        [JsonProperty("Record")]
        public string Record{ get; set; }

        /// <summary>
        /// Origin server type. Valid values:
        /// <li>IP_DOMAIN: IPV4, IPV6, domain type origin server;</li>
        /// <li>COS: COS origin.</li>
        /// <li>AWS_S3: AWS S3 COS origin server.</li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Origin record ID.
        /// </summary>
        [JsonProperty("RecordId")]
        public string RecordId{ get; set; }

        /// <summary>
        /// 【Origin server weight】: A parameter used to control traffic assignment priority. Value range: 0-100 (integer): <li>Empty value: No weight is set, and the system schedules traffic based on the default policy;</li><li>0: The weight is explicitly set to 0, and traffic will not be assigned to this origin server. Note: Make sure at least one origin server has a weight above 0;</li><li>Normal value: The larger the value, the more traffic is assigned;</li>
        /// </summary>
        [JsonProperty("Weight")]
        public ulong? Weight{ get; set; }

        /// <summary>
        /// Whether to use private authentication. This parameter is valid only when RecordType is COS or AWS_S3. Valid values:
        /// <li>true: Enable private authentication;</li>
        /// <li>false: Do not use private authentication.</li>Not specified. Default value: false.
        /// </summary>
        [JsonProperty("Private")]
        public bool? Private{ get; set; }

        /// <summary>
        /// Private authentication parameter. Valid when the origin server type is Private=true.
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

