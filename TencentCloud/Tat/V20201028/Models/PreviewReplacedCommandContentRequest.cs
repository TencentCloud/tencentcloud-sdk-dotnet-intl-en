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

namespace TencentCloud.Tat.V20201028.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PreviewReplacedCommandContentRequest : AbstractModel
    {
        
        /// <summary>
        /// Custom parameters for the preview. The field type is JSON encoded string. For example, {\"varA\": \"222\"}.
        /// `key` is the name of the custom parameter and "value" is its specified value. Both "key" and "value" are strings.
        /// At most 20 custom parameters are supported.
        /// The name of the custom parameter cannot exceed 64 characters and can only contain [a-z], [A-Z], [0-9], [-_].
        /// This parameter can be left empty if DefaultParameters is set for the previewed CommandId.
        /// </summary>
        [JsonProperty("Parameters")]
        public string Parameters{ get; set; }

        /// <summary>
        /// The command to be previewed. If DefaultParameters is set, it is combined with Parameters and Parameters takes priority.
        /// `CommandId` or `Content` must be specified.
        /// </summary>
        [JsonProperty("CommandId")]
        public string CommandId{ get; set; }

        /// <summary>
        /// Base64-encoded command to be previewed. The maximum length is 64 KB.
        /// CommandId or Content must be specified.
        /// </summary>
        [JsonProperty("Content")]
        public string Content{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Parameters", this.Parameters);
            this.SetParamSimple(map, prefix + "CommandId", this.CommandId);
            this.SetParamSimple(map, prefix + "Content", this.Content);
        }
    }
}

