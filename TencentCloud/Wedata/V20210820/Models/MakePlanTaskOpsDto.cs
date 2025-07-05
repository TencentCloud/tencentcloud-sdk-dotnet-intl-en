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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MakePlanTaskOpsDto : AbstractModel
    {
        
        /// <summary>
        /// Basic task informationNote: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("TaskBaseInfo")]
        public TaskOpsDto TaskBaseInfo{ get; set; }

        /// <summary>
        /// Supplemental instances already generated for this task
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("InstanceCount")]
        public long? InstanceCount{ get; set; }

        /// <summary>
        /// Supplementary Task Instance Completion Percentage
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("CompletePercent")]
        public long? CompletePercent{ get; set; }

        /// <summary>
        /// Supplementary Task Instance Success Percentage
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("SuccessPercent")]
        public long? SuccessPercent{ get; set; }

        /// <summary>
        /// Estimated Total Number of Instances Generated, as generation is asynchronous, -1 indicates instances are not fully generated yet
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("InstanceTotalCount")]
        public long? InstanceTotalCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "TaskBaseInfo.", this.TaskBaseInfo);
            this.SetParamSimple(map, prefix + "InstanceCount", this.InstanceCount);
            this.SetParamSimple(map, prefix + "CompletePercent", this.CompletePercent);
            this.SetParamSimple(map, prefix + "SuccessPercent", this.SuccessPercent);
            this.SetParamSimple(map, prefix + "InstanceTotalCount", this.InstanceTotalCount);
        }
    }
}

