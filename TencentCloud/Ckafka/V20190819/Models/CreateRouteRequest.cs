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

namespace TencentCloud.Ckafka.V20190819.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateRouteRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Specifies the ckafka cluster instance id. obtain through the API <a href="https://www.tencentcloud.comom/document/product/597/40835?from_cn_redirect=1">DescribeInstances</a>.</p>.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <P>Specifies the network type of the route (3: vpc routing; 7: internal support route; 1: public network route).</p>.
        /// </summary>
        [JsonProperty("VipType")]
        public long? VipType{ get; set; }

        /// <summary>
        /// <p>vpc network Id. required when vipType is 3.</p>.
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// <p>Specifies the vpc subnet id. required when vipType is 3.</p>.
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// <p>Access type: 0-plaintext; 1-sasl_plaintext; 3-sasl_ssl; 4-sasl_scram_sha_256; 5-sasl_scram_sha_512. defaults to 0. when vipType=3, supports 0,1,3,4,5. when vipType=7, supports 0,1,3. when vipType=1, supports 1,3.</p>.
        /// </summary>
        [JsonProperty("AccessType")]
        public long? AccessType{ get; set; }

        /// <summary>
        /// <P>Specifies whether access management is required. this field has been deprecated.</p>.
        /// </summary>
        [JsonProperty("AuthFlag")]
        public long? AuthFlag{ get; set; }

        /// <summary>
        /// <p>Specifies the caller appId.</p>.
        /// </summary>
        [JsonProperty("CallerAppid")]
        public long? CallerAppid{ get; set; }

        /// <summary>
        /// <P>Public network bandwidth. required for public network route. must be a multiple of 3. no default value.</p>.
        /// </summary>
        [JsonProperty("PublicNetwork")]
        public long? PublicNetwork{ get; set; }

        /// <summary>
        /// <p>vip address.</p>.
        /// </summary>
        [JsonProperty("Ip")]
        public string Ip{ get; set; }

        /// <summary>
        /// <P>Specifies the remark information.</p>.
        /// </summary>
        [JsonProperty("Note")]
        public string Note{ get; set; }

        /// <summary>
        /// <P>Specifies the ordered list of security group associations.</p>.
        /// </summary>
        [JsonProperty("SecurityGroupIds")]
        public string[] SecurityGroupIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "VipType", this.VipType);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "AccessType", this.AccessType);
            this.SetParamSimple(map, prefix + "AuthFlag", this.AuthFlag);
            this.SetParamSimple(map, prefix + "CallerAppid", this.CallerAppid);
            this.SetParamSimple(map, prefix + "PublicNetwork", this.PublicNetwork);
            this.SetParamSimple(map, prefix + "Ip", this.Ip);
            this.SetParamSimple(map, prefix + "Note", this.Note);
            this.SetParamArraySimple(map, prefix + "SecurityGroupIds.", this.SecurityGroupIds);
        }
    }
}

