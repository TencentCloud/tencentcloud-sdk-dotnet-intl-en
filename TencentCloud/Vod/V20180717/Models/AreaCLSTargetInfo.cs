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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AreaCLSTargetInfo : AbstractModel
    {
        
        /// <summary>
        /// Logset region:
        /// <li>ap-guangzhou: Guangzhou;</li>
        /// <li>ap-beijing: Beijing;</li>
        /// <li>ap-chengdu: Chengdu;</li>
        /// <li>ap-chongqing: Chongqing.</li>
        /// <li>ap-nanjing: Nanjing;</li>
        /// <li>ap-shanghai: Shanghai;</li>
        /// <li>ap-singapore: Singapore.</li>
        /// </summary>
        [JsonProperty("CLSRegion")]
        public string CLSRegion{ get; set; }

        /// <summary>
        /// ID of the destination topic for delivery.
        /// </summary>
        [JsonProperty("TopicId")]
        public string TopicId{ get; set; }

        /// <summary>
        /// ID of the target set for submission.
        /// </summary>
        [JsonProperty("LogsetId")]
        public string LogsetId{ get; set; }

        /// <summary>
        /// Log delivery status.
        /// ON: enabled.
        /// OFF: disabled.
        /// </summary>
        [JsonProperty("Switch")]
        public string Switch{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CLSRegion", this.CLSRegion);
            this.SetParamSimple(map, prefix + "TopicId", this.TopicId);
            this.SetParamSimple(map, prefix + "LogsetId", this.LogsetId);
            this.SetParamSimple(map, prefix + "Switch", this.Switch);
        }
    }
}

