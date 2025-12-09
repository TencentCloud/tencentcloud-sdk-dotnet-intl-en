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

namespace TencentCloud.Controlcenter.V20230110.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BaselineStepTaskInfo : AbstractModel
    {
        
        /// <summary>
        /// Specifies the unique Id of the task, which can only contain english letters and digits, and is a 16-character random string.
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// Specifies the unique identifier for the baseline feature item, can only contain english letters, digits, and @, ,._[]-:()()[]+=., with a length of 2-128 characters.
        /// </summary>
        [JsonProperty("Identifier")]
        public string Identifier{ get; set; }

        /// <summary>
        /// Specifies the member account uin of the applied baseline item.
        /// </summary>
        [JsonProperty("MemberUin")]
        public long? MemberUin{ get; set; }

        /// <summary>
        /// Baseline item application status. Running means the baseline item is in application. Success means the baseline item application is successful. Failed means the baseline item application failure. Pending means the baseline item is Pending application. Skipped means the baseline item is Skipped.
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Error code
        /// </summary>
        [JsonProperty("ErrCode")]
        public string ErrCode{ get; set; }

        /// <summary>
        /// Error message
        /// </summary>
        [JsonProperty("ErrMessage")]
        public string ErrMessage{ get; set; }

        /// <summary>
        /// Baseline item deployment output.
        /// </summary>
        [JsonProperty("Output")]
        public string Output{ get; set; }

        /// <summary>
        /// Creation time, represented in ISO8601 standard format as yyyy-MM-dd hh:MM:ss.
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Specifies the last update time in ISO8601 standard representation with format yyyy-MM-dd hh:MM:ss.
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "Identifier", this.Identifier);
            this.SetParamSimple(map, prefix + "MemberUin", this.MemberUin);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "ErrCode", this.ErrCode);
            this.SetParamSimple(map, prefix + "ErrMessage", this.ErrMessage);
            this.SetParamSimple(map, prefix + "Output", this.Output);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
        }
    }
}

