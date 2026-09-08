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

namespace TencentCloud.Captcha.V20190722.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateCaptchaInfoInternationalRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Captcha name</p>
        /// </summary>
        [JsonProperty("AppName")]
        public string AppName{ get; set; }

        /// <summary>
        /// <p>Client type</p><p>Enumeration values:</p><ul><li>web: For web scenario</li><li>android: For Android client</li><li>ios: For iOS client</li></ul><p>Default value: web</p>
        /// </summary>
        [JsonProperty("ChannelInfo")]
        public string ChannelInfo{ get; set; }

        /// <summary>
        /// <p>Verification level</p><p>Enumeration values:</p><ul><li>1: Experience-oriented</li><li>2: Balanced</li><li>3: Security-focused</li></ul><p>Default value: 1</p>
        /// </summary>
        [JsonProperty("VerifyRank")]
        public string VerifyRank{ get; set; }

        /// <summary>
        /// <p>Validation type</p><p>Enumeration values:</p><ul><li>1: Invisible verification. UserSetCapType input 1, DisableInvisibleSwitch must be 2</li><li>2: Slide</li><li>8: Graphical</li><li>9: Voice</li></ul>
        /// </summary>
        [JsonProperty("UserSetCapType")]
        public string UserSetCapType{ get; set; }

        /// <summary>
        /// <p>Interception mode</p><p>Enumeration values:</p><ul><li>block: interception mode</li><li>notify: perception mode</li></ul><p>Default value: notify</p>
        /// </summary>
        [JsonProperty("DefendMode")]
        public string DefendMode{ get; set; }

        /// <summary>
        /// <p>Resource tag, key&amp;value format</p>
        /// </summary>
        [JsonProperty("Tags")]
        public string[] Tags{ get; set; }

        /// <summary>
        /// <p>Verification mechanism</p><p>Enumeration values:</p><ul><li>0: One-Click Verification</li><li>1: Always verify</li><li>2: Invisible verification. DisableInvisibleSwitch input 2, UserSetCapType must be 1</li></ul>
        /// </summary>
        [JsonProperty("DisableInvisibleSwitch")]
        public string DisableInvisibleSwitch{ get; set; }

        /// <summary>
        /// <p>web domain name</p><p>Only valid when ChannelInfo is web</p>
        /// </summary>
        [JsonProperty("VerifyDomain")]
        public string VerifyDomain{ get; set; }

        /// <summary>
        /// <p>app BundleId</p><p>Only valid when ChannelInfo is ios</p>
        /// </summary>
        [JsonProperty("VerifyBundleId")]
        public string VerifyBundleId{ get; set; }

        /// <summary>
        /// <p>app package</p><p>Only valid when ChannelInfo is android</p>
        /// </summary>
        [JsonProperty("VerifyPackage")]
        public string VerifyPackage{ get; set; }

        /// <summary>
        /// <p>Whether to enable captcha encryption. 0: Off. 1: On</p>
        /// </summary>
        [JsonProperty("CheckAppidSwitch")]
        public long? CheckAppidSwitch{ get; set; }

        /// <summary>
        /// <p>Whether to enable non-repeating IV</p><p>Enumeration values:</p><ul><li>0: Off</li><li>1: On</li></ul><p>Input 1 is allowed only when CheckAppidSwitch is 1</p>
        /// </summary>
        [JsonProperty("CheckIvSwitch")]
        public long? CheckIvSwitch{ get; set; }

        /// <summary>
        /// <p>Checkbox display method</p><p>Enumeration values:</p><ul><li>0: simplified version</li><li>1: basic version</li><li>2: invisible version</li></ul>
        /// </summary>
        [JsonProperty("CheckBoxStyle")]
        public string CheckBoxStyle{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppName", this.AppName);
            this.SetParamSimple(map, prefix + "ChannelInfo", this.ChannelInfo);
            this.SetParamSimple(map, prefix + "VerifyRank", this.VerifyRank);
            this.SetParamSimple(map, prefix + "UserSetCapType", this.UserSetCapType);
            this.SetParamSimple(map, prefix + "DefendMode", this.DefendMode);
            this.SetParamArraySimple(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "DisableInvisibleSwitch", this.DisableInvisibleSwitch);
            this.SetParamSimple(map, prefix + "VerifyDomain", this.VerifyDomain);
            this.SetParamSimple(map, prefix + "VerifyBundleId", this.VerifyBundleId);
            this.SetParamSimple(map, prefix + "VerifyPackage", this.VerifyPackage);
            this.SetParamSimple(map, prefix + "CheckAppidSwitch", this.CheckAppidSwitch);
            this.SetParamSimple(map, prefix + "CheckIvSwitch", this.CheckIvSwitch);
            this.SetParamSimple(map, prefix + "CheckBoxStyle", this.CheckBoxStyle);
        }
    }
}

