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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeAgentInstallCommandResponse : AbstractModel
    {
        
        /// <summary>
        /// Linux installation command
        /// </summary>
        [JsonProperty("LinuxCommand")]
        public string LinuxCommand{ get; set; }

        /// <summary>
        /// Windows installation command (Windows 2008 or later)
        /// </summary>
        [JsonProperty("WindowsCommand")]
        public string WindowsCommand{ get; set; }

        /// <summary>
        /// Step 1 in the Window installation command (Windows 2003)
        /// </summary>
        [JsonProperty("WindowsStepOne")]
        public string WindowsStepOne{ get; set; }

        /// <summary>
        /// Step 2 in the Window installation command (Windows 2003)
        /// </summary>
        [JsonProperty("WindowsStepTwo")]
        public string WindowsStepTwo{ get; set; }

        /// <summary>
        /// Download URL of the agent for Windows
        /// </summary>
        [JsonProperty("WindowsDownloadUrl")]
        public string WindowsDownloadUrl{ get; set; }

        /// <summary>
        /// The unique request ID, generated by the server, will be returned for every request (if the request fails to reach the server for other reasons, the request will not obtain a RequestId). RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LinuxCommand", this.LinuxCommand);
            this.SetParamSimple(map, prefix + "WindowsCommand", this.WindowsCommand);
            this.SetParamSimple(map, prefix + "WindowsStepOne", this.WindowsStepOne);
            this.SetParamSimple(map, prefix + "WindowsStepTwo", this.WindowsStepTwo);
            this.SetParamSimple(map, prefix + "WindowsDownloadUrl", this.WindowsDownloadUrl);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

