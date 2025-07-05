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

    public class EscapeRuleEnabled : AbstractModel
    {
        
        /// <summary>
        /// Rule type
        ///    `ESCAPE_HOST_ACESS_FILE`: Host file access escape.
        ///    `ESCAPE_MOUNT_NAMESPACE`: Mount namespace escape.
        ///    `ESCAPE_PRIVILEDGE`: Program privilege escalation escape.
        ///    `ESCAPE_PRIVILEDGE_CONTAINER_START`: Privileged container startup escape.
        ///    `ESCAPE_MOUNT_SENSITIVE_PTAH`: Sensitive path mount.
        ///    `ESCAPE_SYSCALL`: Syscall escape.
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Whether to enable. Valid values: `false` (no); `true` (yes).
        /// </summary>
        [JsonProperty("IsEnable")]
        public bool? IsEnable{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "IsEnable", this.IsEnable);
        }
    }
}

