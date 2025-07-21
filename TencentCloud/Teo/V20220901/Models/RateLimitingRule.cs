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
        /// The ID of precise rate limiting. rule ID supports different rule configuration operations: <li><b>add</b> a new rule: leave the ID empty or do not specify the ID parameter.</li> <li><b>modify</b> an existing rule: specify the rule ID that needs to be updated/modified.</li> <li><b>delete</b> an existing rule: existing Rules not included in the Rules list under the RateLimitingRules parameter will be deleted.</li>.
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// Specifies the name of the precise rate limit.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// The specific content of precise speed limit shall comply with the expression syntax. for detailed specifications, see the product documentation.
        /// </summary>
        [JsonProperty("Condition")]
        public string Condition{ get; set; }

        /// <summary>
        /// Rate threshold request feature match mode. this field is required when Enabled is on.  when there are multiple conditions, composite multiple conditions will perform statistics count. the maximum number of conditions must not exceed 5. valid values: <li><b>http.request.ip</b>: client ip;</li> <li><b>http.request.xff_header_ip</b>: client ip (priority match xff header);</li> <li><b>http.request.uri.path</b>: request access path;</li> <li><b>http.request.cookies['session']</b>: Cookie named session, where session can be replaced with your own specified parameter;</li> <li><b>http.request.headers['user-agent']</b>: http header named user-agent, where user-agent can be replaced with your own specified parameter;</li> <li><b>http.request.ja3</b>: request ja3 fingerprint;</li> <li><b>http.request.uri.query['test']</b>: URL query parameter named test, where test can be replaced with your own specified parameter.</li>.
        /// </summary>
        [JsonProperty("CountBy")]
        public string[] CountBy{ get; set; }

        /// <summary>
        /// Precision rate limiting specifies the cumulative number of interceptions within the time range. value ranges from 1 to 100000.
        /// </summary>
        [JsonProperty("MaxRequestThreshold")]
        public long? MaxRequestThreshold{ get; set; }

        /// <summary>
        /// Specifies the time window for statistics. valid values: <li>1s: 1 second;</li><li>5s: 5 seconds;</li><li>10s: 10 seconds;</li><li>20s: 20 seconds;</li><li>30s: 30 seconds;</li><li>40s: 40 seconds;</li><li>50s: 50 seconds;</li><li>1m: 1 minute;</li><li>2m: 2 minutes;</li><li>5m: 5 minutes;</li><li>10m: 10 minutes;</li><li>1h: 1 hour.</li>.
        /// </summary>
        [JsonProperty("CountingPeriod")]
        public string CountingPeriod{ get; set; }

        /// <summary>
        /// The duration of an Action is only supported in the following units: <li>s: seconds, value range 1–120;</li> <li>m: minutes, value range 1–120;</li> <li>h: hours, value range 1–48;</li> <li>d: days, value range 1–30.</li>.
        /// </summary>
        [JsonProperty("ActionDuration")]
        public string ActionDuration{ get; set; }

        /// <summary>
        /// Precision rate limiting handling methods. valid values: <li>Monitor: Monitor;</li> <li>Deny: block, where DenyActionParameters.Name supports Deny and ReturnCustomPage;</li> <li>Challenge: Challenge, where ChallengeActionParameters.Name supports JSChallenge and ManagedChallenge;</li> <li>Redirect: Redirect to URL;</li>.
        /// </summary>
        [JsonProperty("Action")]
        public SecurityAction Action{ get; set; }

        /// <summary>
        /// Precision rate limiting specifies the priority. value range is 0 to 100. default is 0.
        /// </summary>
        [JsonProperty("Priority")]
        public long? Priority{ get; set; }

        /// <summary>
        /// Whether the precise rate limiting rule is enabled. valid values: <li>on: enabled;</li> <li>off: disabled.</li>.
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

