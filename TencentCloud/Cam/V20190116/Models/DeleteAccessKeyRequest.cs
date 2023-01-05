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

namespace TencentCloud.Cam.V20190116.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DeleteAccessKeyRequest : AbstractModel
    {
        
        /// <summary>
        /// ID of the specified access key that needs to be deleted
        /// </summary>
        [JsonProperty("AccessKeyId")]
        public string AccessKeyId{ get; set; }

        /// <summary>
        /// UIN of the specified user. If this parameter is left empty, the access key will be deleted for the current user by default.
        /// </summary>
        [JsonProperty("TargetUin")]
        public ulong? TargetUin{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AccessKeyId", this.AccessKeyId);
            this.SetParamSimple(map, prefix + "TargetUin", this.TargetUin);
        }
    }
}

