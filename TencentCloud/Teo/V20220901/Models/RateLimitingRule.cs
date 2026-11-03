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

    public class RateLimitingRule : AbstractModel
    {
        
        /// <summary>
        /// <p>ID of the precise rate limiting rule.<br>Different rule configuration operations can be performed by rule ID:<br> <li> <b>Add</b> a new rule: leave ID empty or unspecified;</li><li><b>Modify</b> an existing rule: specify the rule ID that needs to be updated/modified;</li><li><b>Delete</b> an existing rule: existing rules not included in the Rules list in the RateLimitingRules parameter will be deleted.</li></p>
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// <p>Name of the precise rate limit.</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>The specific content of precise rate limiting must comply with expression syntax. For detailed specifications, see <a href="https://www.tencentcloud.com/document/product/1552/125343?from_cn_redirect=1">product document</a>.</p>
        /// </summary>
        [JsonProperty("Condition")]
        public string Condition{ get; set; }

        /// <summary>
        /// <p>Bandwidth limit mode. Within the statistical time window CountingPeriod, for requests that meet the CountBy feature, the following bandwidth limit modes can be configured: <li>Block: Block the access source. When the count exceeds the MaxRequestThreshold, execute the Action on all subsequent requests that meet the feature within the ActionDuration;</li><li>Throttle: Only handle excess requests. When the count exceeds the MaxRequestThreshold, execute the Action only on requests that exceed the threshold, and stop when the window ends. At this point, the ActionDuration parameter will be ignored.</li><br>Default value: Block.</p>
        /// </summary>
        [JsonProperty("Mode")]
        public string Mode{ get; set; }

        /// <summary>
        /// <p>Match mode of the rate threshold request feature. Required when Enabled is on.<br><br>When there are multiple conditions, they will be combined for statistics and calculation. A maximum of 5 conditions is allowed. Valid values:<br><li><b>http.request.ip</b>: client IP;</li><li><b>http.request.xff_header_ip</b>: client IP (priority match XFF header);</li><li><b>http.request.uri.path</b>: access path of the request;</li><li><b>http.request.cookies[&#39;session&#39;]</b>: Cookie named session, where session can be replaced with your own parameter;</li><li><b>http.request.headers[&#39;user-agent&#39;]</b>: HTTP header named user-agent, where user-agent can be replaced with your own parameter;</li><li><b>http.request.ja3</b>: JA3 fingerprint of the request;</li><li><b>http.request.ja4</b>: JA4 fingerprint of the request;</li><li><b>http.request.uri.query[&#39;test&#39;]</b>: URL query parameter named test, where test can be replaced with your own parameter.</li></p>
        /// </summary>
        [JsonProperty("CountBy")]
        public string[] CountBy{ get; set; }

        /// <summary>
        /// <p>Cumulative number of interceptions by precise rate limiting within the time range, with a value range of 1 to 100000.</p>
        /// </summary>
        [JsonProperty("MaxRequestThreshold")]
        public long? MaxRequestThreshold{ get; set; }

        /// <summary>
        /// <p>Time window for statistics. Valid values: <li>1s: 1 second;</li><li>5s: 5 seconds;</li><li>10s: 10 seconds;</li><li>20s: 20 seconds;</li><li>30s: 30 seconds;</li><li>40s: 40 seconds;</li><li>50s: 50 seconds;</li><li>1m: 1 minute;</li><li>2m: 2 minutes;</li><li>5m: 5 minutes;</li><li>10m: 10 minutes;</li><li>1h: 1 hour.</li></p>
        /// </summary>
        [JsonProperty("CountingPeriod")]
        public string CountingPeriod{ get; set; }

        /// <summary>
        /// <p>Duration of the Action. Supported units: <li>s: seconds, value range: 1-120;</li><li>m: minutes, value range: 1-120;</li><li>h: hours, value range: 1-48;</li><li>d: days, value range: 1-30.</li><br>When Mode is Throttle, this parameter will be ignored and will not take effect.</p>
        /// </summary>
        [JsonProperty("ActionDuration")]
        public string ActionDuration{ get; set; }

        /// <summary>
        /// <p>Handling method for precise rate limiting. SecurityAction.Name value range is as follows:</p><ul><li>Allow: allow, where AllowActionParameters supports MinDelayTime and MaxDelayTime configuration;</li><li>Deny: block, where DenyActionParameters supports ReturnCustomPage and Stall configuration;</li><li>Monitor: observe;</li><li>Challenge: challenge, where ChallengeActionParameters.ChallengeOption supports JSChallenge and ManagedChallenge;</li><li>Redirect: redirect to a URL.</li></ul>
        /// </summary>
        [JsonProperty("Action")]
        public SecurityAction Action{ get; set; }

        /// <summary>
        /// <p>Priority of precise rate limiting, ranging from 0 to 100, with a default value of 0.</p>
        /// </summary>
        [JsonProperty("Priority")]
        public long? Priority{ get; set; }

        /// <summary>
        /// <p>Whether the precise rate limiting rule is enabled. Valid values: <li>on: enabled;</li><li>off: disabled.</li></p>
        /// </summary>
        [JsonProperty("Enabled")]
        public string Enabled{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Condition", this.Condition);
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
            this.SetParamArraySimple(map, prefix + "CountBy.", this.CountBy);
            this.SetParamSimple(map, prefix + "MaxRequestThreshold", this.MaxRequestThreshold);
            this.SetParamSimple(map, prefix + "CountingPeriod", this.CountingPeriod);
            this.SetParamSimple(map, prefix + "ActionDuration", this.ActionDuration);
            this.SetParamObj(map, prefix + "Action.", this.Action);
            this.SetParamSimple(map, prefix + "Priority", this.Priority);
            this.SetParamSimple(map, prefix + "Enabled", this.Enabled);
        }
    }
}

