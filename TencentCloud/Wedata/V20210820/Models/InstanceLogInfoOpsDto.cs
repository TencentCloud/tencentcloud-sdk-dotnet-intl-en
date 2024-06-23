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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InstanceLogInfoOpsDto : AbstractModel
    {
        
        /// <summary>
        /// Instance running log
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("LogInfo")]
        public string LogInfo{ get; set; }

        /// <summary>
        /// The Yarn log address submitted by the instance run
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("YarnLogInfo")]
        public string[] YarnLogInfo{ get; set; }

        /// <summary>
        /// The datax log generated by the instance run
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("DataLogInfo")]
        public string DataLogInfo{ get; set; }

        /// <summary>
        /// Third-party Task Execution Log
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("ThirdTaskRunLogInfo")]
        public string ThirdTaskRunLogInfo{ get; set; }

        /// <summary>
        /// Third-party Task Log Link Description
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("ThirdTaskLogUrlDesc")]
        public string ThirdTaskLogUrlDesc{ get; set; }

        /// <summary>
        /// Number of Log Lines
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("LineCount")]
        public long? LineCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LogInfo", this.LogInfo);
            this.SetParamArraySimple(map, prefix + "YarnLogInfo.", this.YarnLogInfo);
            this.SetParamSimple(map, prefix + "DataLogInfo", this.DataLogInfo);
            this.SetParamSimple(map, prefix + "ThirdTaskRunLogInfo", this.ThirdTaskRunLogInfo);
            this.SetParamSimple(map, prefix + "ThirdTaskLogUrlDesc", this.ThirdTaskLogUrlDesc);
            this.SetParamSimple(map, prefix + "LineCount", this.LineCount);
        }
    }
}
