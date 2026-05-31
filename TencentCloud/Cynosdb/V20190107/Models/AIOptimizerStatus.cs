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

namespace TencentCloud.Cynosdb.V20190107.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AIOptimizerStatus : AbstractModel
    {
        
        /// <summary>
        /// <p>Status. closing-Closing, closed-Closed, opening-Opening, training-Training, trained-Trained, train_failed-Training failed.</p>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>Start time.</p>
        /// </summary>
        [JsonProperty("OpenTime")]
        public string OpenTime{ get; set; }

        /// <summary>
        /// <p>Training progress</p>
        /// </summary>
        [JsonProperty("TrainingProgress")]
        public long? TrainingProgress{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "OpenTime", this.OpenTime);
            this.SetParamSimple(map, prefix + "TrainingProgress", this.TrainingProgress);
        }
    }
}

