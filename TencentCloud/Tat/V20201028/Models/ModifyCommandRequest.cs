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

    public class ModifyCommandRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Command ID. call the <a href="https://www.tencentcloud.com/document/api/1340/52681?from_cn_redirect=1">DescribeCommands</a> api to query command details.</p>.
        /// </summary>
        [JsonProperty("CommandId")]
        public string CommandId{ get; set; }

        /// <summary>
        /// <p>Command name. name only supports chinese, english, digits, underscore, separator "-", and decimal point. the maximum length cannot exceed 60 bytes.</p>.
        /// </summary>
        [JsonProperty("CommandName")]
        public string CommandName{ get; set; }

        /// <summary>
        /// <P>Command description. no more than 120 characters.</p>.
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>The Base64-encoded command content, length cannot exceed 64KB.</p>.
        /// </summary>
        [JsonProperty("Content")]
        public string Content{ get; set; }

        /// <summary>
        /// <p>Command type. currently supports SHELL, POWERSHELL, BAT.</p>.
        /// </summary>
        [JsonProperty("CommandType")]
        public string CommandType{ get; set; }

        /// <summary>
        /// <P>Command execution path.</p>.
        /// </summary>
        [JsonProperty("WorkingDirectory")]
        public string WorkingDirectory{ get; set; }

        /// <summary>
        /// <p>Command timeout time.</p><p>value range: [1, 86400].</p><p>unit: seconds.</p><p>default value: 60.</p><p>when specifying the OutputCOSBucketUrl parameter, the timeout period includes the time taken to upload command output to COS.</p>.
        /// </summary>
        [JsonProperty("Timeout")]
        public ulong? Timeout{ get; set; }

        /// <summary>
        /// <p>The default value of custom parameters when the custom parameter feature is enabled. the field type is a json-encoded string, for example: {"varA": "222"}.<br>parameters must not be specified simultaneously for <code>DefaultParameters</code> and <code>DefaultParameterConfs</code>.<br>a comprehensive modification is applied, meaning all new default values must be provided when modifying.<br>this parameter can be modified only when EnableParameter of the command is true. obtain the EnableParameter settings of the command through the <a href="https://www.tencentcloud.com/document/api/1340/52681?from_cn_redirect=1">DescribeCommands (query command details)</a> api.<br>the key is the custom parameter name, and the value is the default value of this parameter. both key and value are string-type.<br>there is an upper limit of 20 custom parameters.<br>custom parameter names must meet the following requirements: the upper limit of character quantity is 64, and the optional range is [a-zA-Z0-9-_].</p>.
        /// </summary>
        [JsonProperty("DefaultParameters")]
        public string DefaultParameters{ get; set; }

        /// <summary>
        /// <p>Custom parameter array. if no parameter value is provided when invoking the command, the default value here will be used to replace it.<br>parameters do not support specifying both <code>DefaultParameters</code> and <code>DefaultParameterConfs</code>.<br>this parameter can be modified only when EnableParameter of the command is true. obtain the EnableParameter settings through the <a href="https://www.tencentcloud.com/document/api/1340/52681?from_cn_redirect=1">DescribeCommands (query command details)</a> api.<br>up to 20 custom parameters are allowed.</p>.
        /// </summary>
        [JsonProperty("DefaultParameterConfs")]
        public DefaultParameterConf[] DefaultParameterConfs{ get; set; }

        /// <summary>
        /// <p>The username to run commands in a CVM or Lighthouse instance.<br>using minimum permission to execute commands is the best practice for permission management. we recommend running cloud assistant commands as a regular user identity.</p>.
        /// </summary>
        [JsonProperty("Username")]
        public string Username{ get; set; }

        /// <summary>
        /// <p>Specifies the cos bucket address for the uploaded log, which must start with https, such as https://BucketName-123454321.cos.ap-beijing.myqcloud.com.</p>.
        /// </summary>
        [JsonProperty("OutputCOSBucketUrl")]
        public string OutputCOSBucketUrl{ get; set; }

        /// <summary>
        /// <P>Specify the directory for logs in the cos bucket. the directory naming has the following rules:</p><ol><li>use a combination of numbers, chinese and english, and visible characters, with a maximum length of 60.</li><li>use / to split the path and quickly create subdirectories.</li><li>consecutive / are not allowed; cannot start with /; cannot use .. as the folder name.</li></ol>.
        /// </summary>
        [JsonProperty("OutputCOSKeyPrefix")]
        public string OutputCOSKeyPrefix{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CommandId", this.CommandId);
            this.SetParamSimple(map, prefix + "CommandName", this.CommandName);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Content", this.Content);
            this.SetParamSimple(map, prefix + "CommandType", this.CommandType);
            this.SetParamSimple(map, prefix + "WorkingDirectory", this.WorkingDirectory);
            this.SetParamSimple(map, prefix + "Timeout", this.Timeout);
            this.SetParamSimple(map, prefix + "DefaultParameters", this.DefaultParameters);
            this.SetParamArrayObj(map, prefix + "DefaultParameterConfs.", this.DefaultParameterConfs);
            this.SetParamSimple(map, prefix + "Username", this.Username);
            this.SetParamSimple(map, prefix + "OutputCOSBucketUrl", this.OutputCOSBucketUrl);
            this.SetParamSimple(map, prefix + "OutputCOSKeyPrefix", this.OutputCOSKeyPrefix);
        }
    }
}

