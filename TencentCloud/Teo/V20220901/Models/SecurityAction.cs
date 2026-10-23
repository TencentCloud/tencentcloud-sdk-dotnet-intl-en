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

    public class SecurityAction : AbstractModel
    {
        
        /// <summary>
        /// <p>Specific actions for safe execution. Valid values:</p><ul><li>Deny: block, prevent requests from accessing site resources;</li><li>Monitor: observe, only record logs;</li><li>Redirect: redirect to URL;</li><li>Disabled: not enabled, do not enable the specified rule;</li><li>Allow: pass, skip the remaining rules of the current security module. Delay response when the AllowActionParameters parameter is configured;</li><li>Challenge: challenge, respond with challenge content;</li><li>BlockIP: to be deprecated, IP blocking;</li><li>ReturnCustomPage: to be deprecated, use a specified page for interception;</li><li>JSChallenge: to be deprecated, JavaScript challenge;</li><li>ManagedChallenge: to be deprecated, managed challenge.</li></ul>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>Additional parameter when Name is Deny.</p>
        /// </summary>
        [JsonProperty("DenyActionParameters")]
        public DenyActionParameters DenyActionParameters{ get; set; }

        /// <summary>
        /// <p>Additional parameter when Name is Redirect.</p>
        /// </summary>
        [JsonProperty("RedirectActionParameters")]
        public RedirectActionParameters RedirectActionParameters{ get; set; }

        /// <summary>
        /// <p>Additional parameter when Name is Allow.</p>
        /// </summary>
        [JsonProperty("AllowActionParameters")]
        public AllowActionParameters AllowActionParameters{ get; set; }

        /// <summary>
        /// <p>Additional parameter when Name is Challenge.</p>
        /// </summary>
        [JsonProperty("ChallengeActionParameters")]
        public ChallengeActionParameters ChallengeActionParameters{ get; set; }

        /// <summary>
        /// <p>To be deprecated. Additional parameter when Name is BlockIP.</p>
        /// </summary>
        [JsonProperty("BlockIPActionParameters")]
        public BlockIPActionParameters BlockIPActionParameters{ get; set; }

        /// <summary>
        /// <p>To be deprecated. An additional parameter when Name is ReturnCustomPage.</p>
        /// </summary>
        [JsonProperty("ReturnCustomPageActionParameters")]
        public ReturnCustomPageActionParameters ReturnCustomPageActionParameters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamObj(map, prefix + "DenyActionParameters.", this.DenyActionParameters);
            this.SetParamObj(map, prefix + "RedirectActionParameters.", this.RedirectActionParameters);
            this.SetParamObj(map, prefix + "AllowActionParameters.", this.AllowActionParameters);
            this.SetParamObj(map, prefix + "ChallengeActionParameters.", this.ChallengeActionParameters);
            this.SetParamObj(map, prefix + "BlockIPActionParameters.", this.BlockIPActionParameters);
            this.SetParamObj(map, prefix + "ReturnCustomPageActionParameters.", this.ReturnCustomPageActionParameters);
        }
    }
}

