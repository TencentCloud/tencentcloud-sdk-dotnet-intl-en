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

namespace TencentCloud.Sts.V20180813.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GetFederationTokenRequest : AbstractModel
    {
        
        /// <summary>
        /// The customizable name of the caller, consisting of letters
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Note:
        /// 
        /// The policy syntax refers to [CAM's Syntax Logic](https://intl.cloud.tencent.com/document/product/598/10603?from_cn_redirect=1).
        /// The policy cannot contain the principal element.
        /// This parameter needs to be URL-encoded. The server will URL-decode this field and grant temporary access credentials based on the processed policy. Please pass the parameter according to the specification.
        /// </summary>
        [JsonProperty("Policy")]
        public string Policy{ get; set; }

        /// <summary>
        /// The validity period of temporary credentials in seconds. Default value: 1,800s. Maximum value for a root account: 7,200s. Maximum value for a sub-account: 129,600s.
        /// </summary>
        [JsonProperty("DurationSeconds")]
        public ulong? DurationSeconds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Policy", this.Policy);
            this.SetParamSimple(map, prefix + "DurationSeconds", this.DurationSeconds);
        }
    }
}

