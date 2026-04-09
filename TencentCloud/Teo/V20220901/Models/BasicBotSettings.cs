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
        /// Client IP source IDC configuration, used for handling access requests from client ips in idcs (data centers). such source requests are not directly accessed by mobile terminals or browser-side.
        /// </summary>
        [JsonProperty("SourceIDC")]
        public SourceIDC SourceIDC{ get; set; }

        /// <summary>
        /// Search engine crawler configuration, used to handle requests from search engine crawlers. the IP, User-Agent, or rDNS results of such requests match known search engine crawlers.
        /// </summary>
        [JsonProperty("SearchEngineBots")]
        public SearchEngineBots SearchEngineBots{ get; set; }

        /// <summary>
        /// Commercial or open-source tool UA feature configuration (original UA feature rule), used to handle access requests from known commercial or open-source tools. the User-Agent header of such requests complies with known commercial or open-source tool features.
        /// </summary>
        [JsonProperty("KnownBotCategories")]
        public KnownBotCategories KnownBotCategories{ get; set; }

        /// <summary>
        /// Threat intelligence database (originally client profile analysis) configuration, used for handling client ips with specific risk characteristics in recent access behavior.
        /// </summary>
        [JsonProperty("IPReputation")]
        public IPReputation IPReputation{ get; set; }

        /// <summary>
        /// Specifies the configuration for Bot intelligent analysis.
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

