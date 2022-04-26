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

    public class CreateCommandRequest : AbstractModel
    {
        
        /// <summary>
        /// Command name. The name can be up to 60 bytes, and contain [a-z], [A-Z], [0-9] and [_-.].
        /// </summary>
        [JsonProperty("CommandName")]
        public string CommandName{ get; set; }

        /// <summary>
        /// Base64-encoded command. The maximum length is 64 KB.
        /// </summary>
        [JsonProperty("Content")]
        public string Content{ get; set; }

        /// <summary>
        /// Command description. The maximum length is 120 characters.
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// Command type. `SHELL` and `POWERSHELL` are supported. The default value is `SHELL`.
        /// </summary>
        [JsonProperty("CommandType")]
        public string CommandType{ get; set; }

        /// <summary>
        /// Command execution path. The default value is /root for `SHELL` commands and C:\Program Files\qcloud\tat_agent\workdir for `POWERSHELL` commands.
        /// </summary>
        [JsonProperty("WorkingDirectory")]
        public string WorkingDirectory{ get; set; }

        /// <summary>
        /// Command timeout period. Default value: 60 seconds. Value range: [1, 86400].
        /// </summary>
        [JsonProperty("Timeout")]
        public ulong? Timeout{ get; set; }

        /// <summary>
        /// Whether to enable the custom parameter feature.
        /// This cannot be modified once created.
        /// Default value: `false`.
        /// </summary>
        [JsonProperty("EnableParameter")]
        public bool? EnableParameter{ get; set; }

        /// <summary>
        /// The default value of the custom parameter value when it is enabled. The field type is JSON encoded string. For example, {\"varA\": \"222\"}.
        /// `key` is the name of the custom parameter and `value` is the default value. Both `key` and `value` are strings.
        /// If no parameter value is provided in the `InvokeCommand` API, the default value is used.
        /// Up to 20 custom parameters are supported.
        /// The name of the custom parameter cannot exceed 64 characters and can contain [a-z], [A-Z], [0-9] and [-_].
        /// </summary>
        [JsonProperty("DefaultParameters")]
        public string DefaultParameters{ get; set; }

        /// <summary>
        /// Tags bound to the command. At most 10 tags are allowed.
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// The username used to execute the command on the CVM or Lighthouse instance.
        /// The principle of least privilege is the best practice for permission management. We recommend you execute TAT commands as a general user. By default, the root user is used to execute commands on Linux and the System user is used on Windows.
        /// </summary>
        [JsonProperty("Username")]
        public string Username{ get; set; }

        /// <summary>
        /// The COS bucket URL for uploading logs. The URL must start with `https`, such as `https://BucketName-123454321.cos.ap-beijing.myqcloud.com`.
        /// </summary>
        [JsonProperty("OutputCOSBucketUrl")]
        public string OutputCOSBucketUrl{ get; set; }

        /// <summary>
        /// The COS bucket directory where the logs are saved. Check below for the rules of the directory name. 
        /// 1. It must be a combination of number, letters, and visible characters. Up to 60 characters are allowed.
        /// 2. Use a slash (/) to create a subdirectory.
        /// 3. Consecutive dots (.) and slashes (/) are not allowed. It can not start with a slash (/). 
        /// </summary>
        [JsonProperty("OutputCOSKeyPrefix")]
        public string OutputCOSKeyPrefix{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CommandName", this.CommandName);
            this.SetParamSimple(map, prefix + "Content", this.Content);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "CommandType", this.CommandType);
            this.SetParamSimple(map, prefix + "WorkingDirectory", this.WorkingDirectory);
            this.SetParamSimple(map, prefix + "Timeout", this.Timeout);
            this.SetParamSimple(map, prefix + "EnableParameter", this.EnableParameter);
            this.SetParamSimple(map, prefix + "DefaultParameters", this.DefaultParameters);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "Username", this.Username);
            this.SetParamSimple(map, prefix + "OutputCOSBucketUrl", this.OutputCOSBucketUrl);
            this.SetParamSimple(map, prefix + "OutputCOSKeyPrefix", this.OutputCOSKeyPrefix);
        }
    }
}

