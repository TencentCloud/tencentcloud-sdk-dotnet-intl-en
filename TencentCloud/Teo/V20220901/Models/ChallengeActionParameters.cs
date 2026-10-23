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

    public class ChallengeActionParameters : AbstractModel
    {
        
        /// <summary>
        /// <p>Specific challenge action for safe execution.</p><p>Enumeration values:</p><ul><li>InterstitialChallenge: interstitial challenge;</li><li>InlineChallenge: embedded challenge (SDK challenge);</li><li>ManagedChallenge: managed challenge. Applicable only to HTML web pages directly accessed by users through a browser. Verification cannot be completed in scenarios such as API interfaces, XHR/AJAX async requests within web pages, mobile apps, and command line tools. Do not configure it;</li><li>JSChallenge: JavaScript challenge. Applicable only to HTML web pages directly accessed by users through a browser. Verification cannot be completed in scenarios such as API interfaces, XHR/AJAX async requests within web pages, mobile apps, and command line tools. Do not configure it.</li></ul>
        /// </summary>
        [JsonProperty("ChallengeOption")]
        public string ChallengeOption{ get; set; }

        /// <summary>
        /// <p>Time interval for repeating the challenge. This field is required when ChallengeOption is InterstitialChallenge/InlineChallenge. Default value: 300s. Supported units: <li>s: second, value ranges from 1 to 60;</li><li>m: minute, value ranges from 1 to 60;</li><li>h: hour, value ranges from 1 to 24.</li></p>
        /// </summary>
        [JsonProperty("Interval")]
        public string Interval{ get; set; }

        /// <summary>
        /// <p>Client authentication method ID. This field is required when Name is InterstitialChallenge/InlineChallenge.</p>
        /// </summary>
        [JsonProperty("AttesterId")]
        public string AttesterId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ChallengeOption", this.ChallengeOption);
            this.SetParamSimple(map, prefix + "Interval", this.Interval);
            this.SetParamSimple(map, prefix + "AttesterId", this.AttesterId);
        }
    }
}

