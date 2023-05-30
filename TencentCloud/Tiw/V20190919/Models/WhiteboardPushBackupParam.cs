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

namespace TencentCloud.Tiw.V20190919.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class WhiteboardPushBackupParam : AbstractModel
    {
        
        /// <summary>
        /// User ID used by the whiteboard push service for entering a room,
        /// The ID must be an unused ID in the SDK. The whiteboard push service uses the user ID to enter the room for whiteboard push. If this ID is already used in the SDK, the SDK and recording service will conflict, affecting the pushing operation.
        /// </summary>
        [JsonProperty("PushUserId")]
        public string PushUserId{ get; set; }

        /// <summary>
        /// Signature corresponding to the PushUserId ID.
        /// </summary>
        [JsonProperty("PushUserSig")]
        public string PushUserSig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PushUserId", this.PushUserId);
            this.SetParamSimple(map, prefix + "PushUserSig", this.PushUserSig);
        }
    }
}

