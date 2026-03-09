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

    public class Command : AbstractModel
    {
        
        /// <summary>
        /// <p>Command ID.</p>.
        /// </summary>
        [JsonProperty("CommandId")]
        public string CommandId{ get; set; }

        /// <summary>
        /// <P>Command name.</p>.
        /// </summary>
        [JsonProperty("CommandName")]
        public string CommandName{ get; set; }

        /// <summary>
        /// <P>Command description.</p>.
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>The Base64-encoded command content.</p>.
        /// </summary>
        [JsonProperty("Content")]
        public string Content{ get; set; }

        /// <summary>
        /// <p>Command type. value is one of SHELL, POWERSHELL, BAT.</p>.
        /// </summary>
        [JsonProperty("CommandType")]
        public string CommandType{ get; set; }

        /// <summary>
        /// <P>Command execution path.</p>.
        /// </summary>
        [JsonProperty("WorkingDirectory")]
        public string WorkingDirectory{ get; set; }

        /// <summary>
        /// <p>Command timeout time.</p><p>unit: seconds.</p><p>when specifying the OutputCOSBucketUrl parameter, the timeout period includes the time taken to upload command output to COS.</p>.
        /// </summary>
        [JsonProperty("Timeout")]
        public ulong? Timeout{ get; set; }

        /// <summary>
        /// <p>Command creation time. the format is YYYY-MM-DDThh:MM:ssZ.</p>.
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// <p>Command last update time. format: YYYY-MM-DDThh:MM:ssZ.</p>.
        /// </summary>
        [JsonProperty("UpdatedTime")]
        public string UpdatedTime{ get; set; }

        /// <summary>
        /// <P>Whether to enable the custom parameter feature.</p>.
        /// </summary>
        [JsonProperty("EnableParameter")]
        public bool? EnableParameter{ get; set; }

        /// <summary>
        /// <P>Default value of custom parameter.</p>.
        /// </summary>
        [JsonProperty("DefaultParameters")]
        public string DefaultParameters{ get; set; }

        /// <summary>
        /// <P>Default value of custom parameters.</p>.
        /// </summary>
        [JsonProperty("DefaultParameterConfs")]
        public DefaultParameterConf[] DefaultParameterConfs{ get; set; }

        /// <summary>
        /// <P>Command association scenarios</p>.
        /// </summary>
        [JsonProperty("Scenes")]
        public string[] Scenes{ get; set; }

        /// <summary>
        /// <P>Structured description of the command. public commands have values, and user commands are empty strings.</p>.
        /// </summary>
        [JsonProperty("FormattedDescription")]
        public string FormattedDescription{ get; set; }

        /// <summary>
        /// <p>Command creator.</p><p>enumeration value:</p><ul><li>TAT: public command</li><li>USER: personal creation command</li></ul>.
        /// </summary>
        [JsonProperty("CreatedBy")]
        public string CreatedBy{ get; set; }

        /// <summary>
        /// <P>Tag list associated with the command.</p>.
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// <P>Username to run command on the instance.</p>.
        /// </summary>
        [JsonProperty("Username")]
        public string Username{ get; set; }

        /// <summary>
        /// <P>The cos bucket address for log upload.</p>.
        /// </summary>
        [JsonProperty("OutputCOSBucketUrl")]
        public string OutputCOSBucketUrl{ get; set; }

        /// <summary>
        /// <P>Directory of logs in the cos bucket.</p>.
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
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "UpdatedTime", this.UpdatedTime);
            this.SetParamSimple(map, prefix + "EnableParameter", this.EnableParameter);
            this.SetParamSimple(map, prefix + "DefaultParameters", this.DefaultParameters);
            this.SetParamArrayObj(map, prefix + "DefaultParameterConfs.", this.DefaultParameterConfs);
            this.SetParamArraySimple(map, prefix + "Scenes.", this.Scenes);
            this.SetParamSimple(map, prefix + "FormattedDescription", this.FormattedDescription);
            this.SetParamSimple(map, prefix + "CreatedBy", this.CreatedBy);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "Username", this.Username);
            this.SetParamSimple(map, prefix + "OutputCOSBucketUrl", this.OutputCOSBucketUrl);
            this.SetParamSimple(map, prefix + "OutputCOSKeyPrefix", this.OutputCOSKeyPrefix);
        }
    }
}

