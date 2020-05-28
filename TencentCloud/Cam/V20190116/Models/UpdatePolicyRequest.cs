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

namespace TencentCloud.Cam.V20190116.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpdatePolicyRequest : AbstractModel
    {
        
        /// <summary>
        /// Policy ID
        /// </summary>
        [JsonProperty("PolicyId")]
        public ulong? PolicyId{ get; set; }

        /// <summary>
        /// Policy Name
        /// </summary>
        [JsonProperty("PolicyName")]
        public string PolicyName{ get; set; }

        /// <summary>
        /// Policy description
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// Policy documentation, for example: `{"version":"2.0","statement":[{"action":"name/sts:AssumeRole","effect":"allow","principal":{"service":["cloudaudit.cloud.tencent.com","cls.cloud.tencent.com"]}}]}`, where `principal` is used to specify the service that is authorized to use the role. For more information about this parameter, see **RoleInfo** under **Output Parameters** in the [GetRole](https://cloud.tencent.com/document/product/598/36221).
        /// </summary>
        [JsonProperty("PolicyDocument")]
        public string PolicyDocument{ get; set; }

        /// <summary>
        /// Preset policy remark
        /// </summary>
        [JsonProperty("Alias")]
        public string Alias{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PolicyId", this.PolicyId);
            this.SetParamSimple(map, prefix + "PolicyName", this.PolicyName);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "PolicyDocument", this.PolicyDocument);
            this.SetParamSimple(map, prefix + "Alias", this.Alias);
        }
    }
}

