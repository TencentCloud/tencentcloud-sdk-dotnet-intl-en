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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ProcessDetailInfo : AbstractModel
    {
        
        /// <summary>
        /// Process name
        /// </summary>
        [JsonProperty("ProcessName")]
        public string ProcessName{ get; set; }

        /// <summary>
        /// Process permission
        /// </summary>
        [JsonProperty("ProcessAuthority")]
        public string ProcessAuthority{ get; set; }

        /// <summary>
        /// Process PID
        /// </summary>
        [JsonProperty("ProcessId")]
        public ulong? ProcessId{ get; set; }

        /// <summary>
        /// Process initiator
        /// </summary>
        [JsonProperty("ProcessStartUser")]
        public string ProcessStartUser{ get; set; }

        /// <summary>
        /// Process user group
        /// </summary>
        [JsonProperty("ProcessUserGroup")]
        public string ProcessUserGroup{ get; set; }

        /// <summary>
        /// Process path
        /// </summary>
        [JsonProperty("ProcessPath")]
        public string ProcessPath{ get; set; }

        /// <summary>
        /// Process tree
        /// </summary>
        [JsonProperty("ProcessTree")]
        public string ProcessTree{ get; set; }

        /// <summary>
        /// Process MD5
        /// </summary>
        [JsonProperty("ProcessMd5")]
        public string ProcessMd5{ get; set; }

        /// <summary>
        /// Process command line parameter
        /// </summary>
        [JsonProperty("ProcessParam")]
        public string ProcessParam{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProcessName", this.ProcessName);
            this.SetParamSimple(map, prefix + "ProcessAuthority", this.ProcessAuthority);
            this.SetParamSimple(map, prefix + "ProcessId", this.ProcessId);
            this.SetParamSimple(map, prefix + "ProcessStartUser", this.ProcessStartUser);
            this.SetParamSimple(map, prefix + "ProcessUserGroup", this.ProcessUserGroup);
            this.SetParamSimple(map, prefix + "ProcessPath", this.ProcessPath);
            this.SetParamSimple(map, prefix + "ProcessTree", this.ProcessTree);
            this.SetParamSimple(map, prefix + "ProcessMd5", this.ProcessMd5);
            this.SetParamSimple(map, prefix + "ProcessParam", this.ProcessParam);
        }
    }
}

