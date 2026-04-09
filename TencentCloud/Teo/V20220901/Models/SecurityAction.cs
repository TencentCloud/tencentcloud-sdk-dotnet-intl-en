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
        /// Specifies the specific actions for safe execution. valid values:.
        /// <Li>Deny. specifies to block requests from accessing site resources.</li>.
        /// <Li>Monitor: observation, only record logs.</li>.
        /// <li>Redirect: Redirect to URL.</li>.
        /// <Li>Disabled: specifies that the rule is not enabled.</li>.
        /// <Li>Allow: specifies whether to allow access with delayed processing of requests.</li>.
        /// <Li>Challenge: specifies the challenge content to respond to.</li>.
        /// <Li>Trans: pass and allow requests to directly access site resources.</li>.
        /// <Li>BlockIP: to be deprecated. ip block.</li>.
        /// <Li>ReturnCustomPage: to be deprecated. use specified page for interception.</li>.
        /// <li>JSChallenge: to be deprecated, JavaScript challenge;</li>.
        /// <Li>ManagedChallenge: to be deprecated. managed challenge.</li>.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Additional parameters when Name is Deny.
        /// </summary>
        [JsonProperty("DenyActionParameters")]
        public DenyActionParameters DenyActionParameters{ get; set; }

        /// <summary>
        /// Additional parameter when Name is Redirect.
        /// </summary>
        [JsonProperty("RedirectActionParameters")]
        public RedirectActionParameters RedirectActionParameters{ get; set; }

        /// <summary>
        /// Additional parameters when Name is Allow.
        /// </summary>
        [JsonProperty("AllowActionParameters")]
        public AllowActionParameters AllowActionParameters{ get; set; }

        /// <summary>
        /// Additional parameter when Name is Challenge.
        /// </summary>
        [JsonProperty("ChallengeActionParameters")]
        public ChallengeActionParameters ChallengeActionParameters{ get; set; }

        /// <summary>
        /// To be deprecated, additional parameter when Name is BlockIP.
        /// </summary>
        [JsonProperty("BlockIPActionParameters")]
        public BlockIPActionParameters BlockIPActionParameters{ get; set; }

        /// <summary>
        /// To be deprecated, additional parameter when Name is ReturnCustomPage.
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

