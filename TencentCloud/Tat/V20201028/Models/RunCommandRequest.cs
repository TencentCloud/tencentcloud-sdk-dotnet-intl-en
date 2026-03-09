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

namespace TencentCloud.Tat.V20201028.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RunCommandRequest : AbstractModel
    {
        
        /// <summary>
        /// Base64-encoded command. The maximum length is 64 KB.
        /// </summary>
        [JsonProperty("Content")]
        public string Content{ get; set; }

        /// <summary>
        /// Instance ID list for the command to be executed, with a cap of 200.
        /// 
        /// Instance ID can be obtained through the query instance interface of corresponding cloud services. currently supported instance types:.
        /// - CVM
        /// - Lighthouse
        /// -TAT register instance.
        /// </summary>
        [JsonProperty("InstanceIds")]
        public string[] InstanceIds{ get; set; }

        /// <summary>
        /// Command name. The name can be up to 60 bytes, and contain [a-z], [A-Z], [0-9] and [_-.].
        /// </summary>
        [JsonProperty("CommandName")]
        public string CommandName{ get; set; }

        /// <summary>
        /// Command description. The maximum length is 120 characters.
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// Command type. currently supports SHELL, POWERSHELL, BAT. default: SHELL.
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
        /// Whether to save the command. value range:.
        /// <li>true: save</li>.
        /// <li>false: not saved.</li>.
        /// The default value is false.
        /// </summary>
        [JsonProperty("SaveCommand")]
        public bool? SaveCommand{ get; set; }

        /// <summary>
        /// Whether to enable the custom parameter feature.
        /// Once created, this value does not offer modification.
        /// Valid values:.
        /// <li>true: enable</li>.
        /// <li>false: disabled.</li>.
        /// The default value is false.
        /// </summary>
        [JsonProperty("EnableParameter")]
        public bool? EnableParameter{ get; set; }

        /// <summary>
        /// Enable the custom parameter feature. default value of the custom parameter. field type is json encoded string. for example: {"varA": "222"}.
        /// The key is the custom parameter name, and the value is the default. both kv are string-type.
        /// This parameter can be set only when the EnableParameter of the command is true.
        /// Parameters must not be specified simultaneously `DefaultParameters` and `DefaultParameterConfs`.
        /// If Parameters is not provided, the default value here will be used to replace.
        /// Custom parameters can be up to 20.
        /// The custom parameter name must meet the following standard: the number of characters has a cap of 64, and the optional range is [a-zA-Z0-9-_].
        /// </summary>
        [JsonProperty("DefaultParameters")]
        public string DefaultParameters{ get; set; }

        /// <summary>
        /// Custom parameter array. if Parameters is not provided, the default value here will be used to replace. up to 20 custom Parameters are allowed.
        /// If Parameters is not provided, the default value here will be used to replace.
        /// This parameter can be set only when the EnableParameter of the command is true.
        /// Parameters must not be specified simultaneously `DefaultParameters` and `DefaultParameterConfs`.
        /// </summary>
        [JsonProperty("DefaultParameterConfs")]
        public DefaultParameterConf[] DefaultParameterConfs{ get; set; }

        /// <summary>
        /// Custom parameter of Command. field type is json encoded string. for example: {"varA": "222"}.
        /// The key is the custom parameter name, and the value is the default. both kv are string-type.
        /// This parameter can be set only when the EnableParameter of the command is true.
        /// If the parameter value is not provided, DefaultParameters or DefaultParameterConfs will be used.
        /// Custom parameters can be up to 20.
        /// The custom parameter name must meet the following standard: the number of characters has a cap of 64, and the optional range is [a-zA-Z0-9-_].
        /// </summary>
        [JsonProperty("Parameters")]
        public string Parameters{ get; set; }

        /// <summary>
        /// The tags of the command. It is available when `SaveCommand` is `True`. A maximum of 10 tags are allowed.
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// The username used to execute the command on the CVM or Lighthouse instance.
        /// The principle of least privilege is the best practice for permission management. We recommend you execute TAT commands as a general user. By default, the user `root` is used to execute commands on Linux and the user `System` is used on Windows.
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
        /// 3. ".." can not be used as the folder name. It cannot start with a slash (/), and cannot contain consecutive slashes.
        /// </summary>
        [JsonProperty("OutputCOSKeyPrefix")]
        public string OutputCOSKeyPrefix{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Content", this.Content);
            this.SetParamArraySimple(map, prefix + "InstanceIds.", this.InstanceIds);
            this.SetParamSimple(map, prefix + "CommandName", this.CommandName);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "CommandType", this.CommandType);
            this.SetParamSimple(map, prefix + "WorkingDirectory", this.WorkingDirectory);
            this.SetParamSimple(map, prefix + "Timeout", this.Timeout);
            this.SetParamSimple(map, prefix + "SaveCommand", this.SaveCommand);
            this.SetParamSimple(map, prefix + "EnableParameter", this.EnableParameter);
            this.SetParamSimple(map, prefix + "DefaultParameters", this.DefaultParameters);
            this.SetParamArrayObj(map, prefix + "DefaultParameterConfs.", this.DefaultParameterConfs);
            this.SetParamSimple(map, prefix + "Parameters", this.Parameters);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "Username", this.Username);
            this.SetParamSimple(map, prefix + "OutputCOSBucketUrl", this.OutputCOSBucketUrl);
            this.SetParamSimple(map, prefix + "OutputCOSKeyPrefix", this.OutputCOSKeyPrefix);
        }
    }
}

