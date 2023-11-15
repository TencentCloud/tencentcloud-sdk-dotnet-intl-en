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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TaskLogURL : AbstractModel
    {
        
        /// <summary>
        /// Temp download URL for the report
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("URL")]
        public string URL{ get; set; }

        /// <summary>
        /// Task report ID
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("LogId")]
        public string LogId{ get; set; }

        /// <summary>
        /// Task report name
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TaskLogName")]
        public string TaskLogName{ get; set; }

        /// <summary>
        /// APP ID
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AppId")]
        public string AppId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "URL", this.URL);
            this.SetParamSimple(map, prefix + "LogId", this.LogId);
            this.SetParamSimple(map, prefix + "TaskLogName", this.TaskLogName);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
        }
    }
}

