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

    public class BasicBotSettings : AbstractModel
    {
        
        /// <summary>
        /// Source IDC configuration of the client IP, used for handling access requests from client IPs in IDCs (data centers). This type of source request is not directly accessed from a mobile terminal or browser side.
        /// </summary>
        [JsonProperty("SourceIDC")]
        public SourceIDC SourceIDC{ get; set; }

        /// <summary>
        /// Search engine crawler configuration, used for handling requests from search engine crawlers. The IP, User-Agent, or rDNS results of such requests match known search engine crawlers.
        /// </summary>
        [JsonProperty("SearchEngineBots")]
        public SearchEngineBots SearchEngineBots{ get; set; }

        /// <summary>
        /// UA feature configuration for commercial or open-source tools (formerly UA feature rules), used for handling access requests from known commercial or open-source tools. The User-Agent header of such requests matches the features of known commercial or open-source tools.
        /// </summary>
        [JsonProperty("KnownBotCategories")]
        public KnownBotCategories KnownBotCategories{ get; set; }

        /// <summary>
        /// IP threat intelligence database (formerly client profile analysis) configuration, used for handling client IP addresses with specific risk characteristics in recent access behavior.
        /// </summary>
        [JsonProperty("IPReputation")]
        public IPReputation IPReputation{ get; set; }

        /// <summary>
        /// Specific configuration for Bot intelligent analysis.
        /// </summary>
        [JsonProperty("BotIntelligence")]
        public BotIntelligence BotIntelligence{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "SourceIDC.", this.SourceIDC);
            this.SetParamObj(map, prefix + "SearchEngineBots.", this.SearchEngineBots);
            this.SetParamObj(map, prefix + "KnownBotCategories.", this.KnownBotCategories);
            this.SetParamObj(map, prefix + "IPReputation.", this.IPReputation);
            this.SetParamObj(map, prefix + "BotIntelligence.", this.BotIntelligence);
        }
    }
}

