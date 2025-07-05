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

    public class OpsTaskCanvasInfoList : AbstractModel
    {
        
        /// <summary>
        /// Canvas Task Information
        /// </summary>
        [JsonProperty("TasksList")]
        public OpsTaskCanvasDto[] TasksList{ get; set; }

        /// <summary>
        /// Canvas Task Link Information
        /// </summary>
        [JsonProperty("LinksList")]
        public OpsTaskLinkInfoDto[] LinksList{ get; set; }

        /// <summary>
        /// Canvas Cyclic Dependency Task Information
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("CirculateTaskList")]
        public OpsTaskCanvasDto[] CirculateTaskList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "TasksList.", this.TasksList);
            this.SetParamArrayObj(map, prefix + "LinksList.", this.LinksList);
            this.SetParamArrayObj(map, prefix + "CirculateTaskList.", this.CirculateTaskList);
        }
    }
}

