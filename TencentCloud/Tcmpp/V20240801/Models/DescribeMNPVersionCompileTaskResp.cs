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

namespace TencentCloud.Tcmpp.V20240801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeMNPVersionCompileTaskResp : AbstractModel
    {
        
        /// <summary>
        /// Mini program ID
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MNPId")]
        public string MNPId{ get; set; }

        /// <summary>
        /// Task ID
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// 1: Pending; 20: Running; 30: Failed; 60: Succeeded 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TaskStatus")]
        public long? TaskStatus{ get; set; }

        /// <summary>
        /// Task status message
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TaskMsg")]
        public string TaskMsg{ get; set; }

        /// <summary>
        /// QR code address
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("QrCodeUrl")]
        public string QrCodeUrl{ get; set; }

        /// <summary>
        /// Packet size
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PkgSize")]
        public long? PkgSize{ get; set; }

        /// <summary>
        /// Subpackage information
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SubPkgInfos")]
        public DescribeMNPVersionCompileTaskSubSimpleInfo[] SubPkgInfos{ get; set; }

        /// <summary>
        /// QR code content
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("QrCodeContent")]
        public string QrCodeContent{ get; set; }

        /// <summary>
        /// Additional information
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ExtInfo")]
        public DescribeMNPVersionCompileTaskExtInfo ExtInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MNPId", this.MNPId);
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "TaskStatus", this.TaskStatus);
            this.SetParamSimple(map, prefix + "TaskMsg", this.TaskMsg);
            this.SetParamSimple(map, prefix + "QrCodeUrl", this.QrCodeUrl);
            this.SetParamSimple(map, prefix + "PkgSize", this.PkgSize);
            this.SetParamArrayObj(map, prefix + "SubPkgInfos.", this.SubPkgInfos);
            this.SetParamSimple(map, prefix + "QrCodeContent", this.QrCodeContent);
            this.SetParamObj(map, prefix + "ExtInfo.", this.ExtInfo);
        }
    }
}

