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

    public class AddEscapeWhiteListRequest : AbstractModel
    {
        
        /// <summary>
        /// Allowed event type
        ///    `ESCAPE_CGROUPS`: Cgroup escape.
        ///    `ESCAPE_TAMPER_SENSITIVE_FILE`: File tamper escape.
        ///    `ESCAPE_DOCKER_API`: Docker API access escape.
        ///    `ESCAPE_VUL_OCCURRED`: Vulnerability exploit.
        ///    `MOUNT_SENSITIVE_PTAH`: Sensitive path mount.
        ///    `PRIVILEGE_CONTAINER_START`: Privileged container.
        ///    `PRIVILEGE`: Program privilege escalation escape.
        /// </summary>
        [JsonProperty("EventType")]
        public string[] EventType{ get; set; }

        /// <summary>
        /// Array of allowed image IDs
        /// </summary>
        [JsonProperty("ImageIDs")]
        public string[] ImageIDs{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "EventType.", this.EventType);
            this.SetParamArraySimple(map, prefix + "ImageIDs.", this.ImageIDs);
        }
    }
}

