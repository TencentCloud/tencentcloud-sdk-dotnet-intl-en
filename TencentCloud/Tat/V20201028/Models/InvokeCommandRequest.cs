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

    public class InvokeCommandRequest : AbstractModel
    {
        
        /// <summary>
        /// Pending trigger command ID. call the [DescribeCommands](https://www.tencentcloud.comom/document/api/1340/52681?from_cn_redirect=1) api to query command details.
        /// </summary>
        [JsonProperty("CommandId")]
        public string CommandId{ get; set; }

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
        /// Custom parameter of Command. field type is json encoded string. for example: {"varA": "222"}.
        /// The key is the custom parameter name, and the value is the default. both kv are string-type.
        /// This parameter can be set only when the EnableParameter of the command is true. you can obtain the EnableParameter settings through the [DescribeCommands (detailed command information)](https://www.tencentcloud.comom/document/api/1340/52681?from_cn_redirect=1) api.
        /// If the parameter value is not provided, the DefaultParameters or DefaultParameterConfs of Command will be used to replace it.
        /// Custom parameters can be up to 20.
        /// The custom parameter name must meet the following standard: the number of characters has a cap of 64, and the optional range is [a-zA-Z0-9-_].
        /// </summary>
        [JsonProperty("Parameters")]
        public string Parameters{ get; set; }

        /// <summary>
        /// The username used to execute the command on the CVM or Lighthouse instance.
        /// The principle of the least privilege is the best practice for permission management. We recommend you execute TAT commands as a general user. If this is not specified, the Username of the command is used by default.
        /// </summary>
        [JsonProperty("Username")]
        public string Username{ get; set; }

        /// <summary>
        /// Execution path of the command. The WorkingDirectory of the command is used by default.
        /// </summary>
        [JsonProperty("WorkingDirectory")]
        public string WorkingDirectory{ get; set; }

        /// <summary>
        /// Command timeout period. Value range: [1, 86400]. The Timeout of the command is used by default.
        /// </summary>
        [JsonProperty("Timeout")]
        public ulong? Timeout{ get; set; }

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
            this.SetParamSimple(map, prefix + "CommandId", this.CommandId);
            this.SetParamArraySimple(map, prefix + "InstanceIds.", this.InstanceIds);
            this.SetParamSimple(map, prefix + "Parameters", this.Parameters);
            this.SetParamSimple(map, prefix + "Username", this.Username);
            this.SetParamSimple(map, prefix + "WorkingDirectory", this.WorkingDirectory);
            this.SetParamSimple(map, prefix + "Timeout", this.Timeout);
            this.SetParamSimple(map, prefix + "OutputCOSBucketUrl", this.OutputCOSBucketUrl);
            this.SetParamSimple(map, prefix + "OutputCOSKeyPrefix", this.OutputCOSKeyPrefix);
        }
    }
}

