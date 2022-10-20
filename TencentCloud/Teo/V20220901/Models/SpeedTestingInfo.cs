/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

    public class SpeedTestingInfo : AbstractModel
    {
        
        /// <summary>
        /// The task status. Values:
        /// <li>`200`: The task completed.</li>
        /// <li>`100`: The task is running.</li>
        /// <li>`503`: The task failed.</li>
        /// </summary>
        [JsonProperty("StatusCode")]
        public long? StatusCode{ get; set; }

        /// <summary>
        /// ID of the site test task.
        /// </summary>
        [JsonProperty("TestId")]
        public string TestId{ get; set; }

        /// <summary>
        /// The settings of the site test task.
        /// </summary>
        [JsonProperty("SpeedTestingConfig")]
        public SpeedTestingConfig SpeedTestingConfig{ get; set; }

        /// <summary>
        /// The site test result.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SpeedTestingStatistics")]
        public SpeedTestingStatistics SpeedTestingStatistics{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StatusCode", this.StatusCode);
            this.SetParamSimple(map, prefix + "TestId", this.TestId);
            this.SetParamObj(map, prefix + "SpeedTestingConfig.", this.SpeedTestingConfig);
            this.SetParamObj(map, prefix + "SpeedTestingStatistics.", this.SpeedTestingStatistics);
        }
    }
}

