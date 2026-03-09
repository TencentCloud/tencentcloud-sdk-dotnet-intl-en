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

    public class ModifyInvokerRequest : AbstractModel
    {
        
        /// <summary>
        /// Executor ID to be modified.
        /// 
        /// Call the [DescribeInvokers](https://www.tencentcloud.comom/document/api/1340/61759?from_cn_redirect=1) api to query execution.
        /// </summary>
        [JsonProperty("InvokerId")]
        public string InvokerId{ get; set; }

        /// <summary>
        /// Executor name to be modified. length not exceeding 120 characters.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Executor type to be modified.
        /// 
        /// Selectable values (currently only support one):.
        /// 
        /// -`SCHEDULE`: period type executor.
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Command ID to be modified.
        /// 
        /// Call the [DescribeCommands](https://www.tencentcloud.comom/document/api/1340/52681?from_cn_redirect=1) api to query command details.
        /// </summary>
        [JsonProperty("CommandId")]
        public string CommandId{ get; set; }

        /// <summary>
        /// Username to be modified. length not exceeding 256 characters.
        /// </summary>
        [JsonProperty("Username")]
        public string Username{ get; set; }

        /// <summary>
        /// Custom parameters to be modified. field type is JSON encode string.
        /// 
        /// This parameter can be set only when EnableParameter of the command specified by CommandId is true. obtain the EnableParameter settings through the [DescribeCommands (query command details)](https://www.tencentcloud.comom/document/api/1340/52681?from_cn_redirect=1) api.
        /// </summary>
        [JsonProperty("Parameters")]
        public string Parameters{ get; set; }

        /// <summary>
        /// List of instance ids to be modified. list length limit 100.
        /// 
        /// You can get the instance ID through the query instance interface of corresponding cloud services. currently supports instance types: CVM, Lighthouse, and TAT managed instances.
        /// 
        /// The instance needs to have the TAT client installed, and the client must be in Online status. you can query client status via the [DescribeAutomationAgentStatus](https://www.tencentcloud.comom/document/api/1340/52682?from_cn_redirect=1) api.
        /// </summary>
        [JsonProperty("InstanceIds")]
        public string[] InstanceIds{ get; set; }

        /// <summary>
        /// Recurring invoker settings to be modified.
        /// 
        /// Change the executor type to `SCHEDULE` and specify this parameter.
        /// </summary>
        [JsonProperty("ScheduleSettings")]
        public ScheduleSettings ScheduleSettings{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InvokerId", this.InvokerId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "CommandId", this.CommandId);
            this.SetParamSimple(map, prefix + "Username", this.Username);
            this.SetParamSimple(map, prefix + "Parameters", this.Parameters);
            this.SetParamArraySimple(map, prefix + "InstanceIds.", this.InstanceIds);
            this.SetParamObj(map, prefix + "ScheduleSettings.", this.ScheduleSettings);
        }
    }
}

