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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DashboardTopicInfo : AbstractModel
    {
        
        /// <summary>
        /// Topic ID
        /// </summary>
        [JsonProperty("TopicId")]
        public string TopicId{ get; set; }

        /// <summary>
        /// Region of the topic.
        /// - 1: Guangzhou
        /// -4: Shanghai
        /// - 5: Hong Kong (China)
        /// - 7: Shanghai Finance
        /// -8: Beijing
        /// -9: Singapore
        /// - 11: Shenzhen Finance
        /// - 15: Silicon Valley
        /// -16: Chengdu
        /// -17: Frankfurt
        /// - 18: Seoul
        /// - 19: Chongqing
        /// - 22: Virginia
        /// - 23: Bangkok
        /// - 25: Tokyo
        /// - 33: Nanjing
        /// - 36: Tianjin
        /// -39: Taipei (China)
        /// - 46: Beijing Finance
        /// -72: Jakarta
        /// -74: São Paulo
        /// -78: Shanghai Autonomous Driving Cloud
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TopicId", this.TopicId);
            this.SetParamSimple(map, prefix + "Region", this.Region);
        }
    }
}

