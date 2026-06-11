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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MemShellRule : AbstractModel
    {
        
        /// <summary>
        /// Rule ID
        /// </summary>
        [JsonProperty("Id")]
        public ulong? Id{ get; set; }

        /// <summary>
        /// Client ID
        /// </summary>
        [JsonProperty("UuidHostips")]
        public UuidHostip[] UuidHostips{ get; set; }

        /// <summary>
        /// Logical operator. 0: 5 valid regular expression logical ANDs; 1: logical OR.
        /// </summary>
        [JsonProperty("LogicalSymbol")]
        public ulong? LogicalSymbol{ get; set; }

        /// <summary>
        /// Class name regular expression, which is not matched if empty.
        /// </summary>
        [JsonProperty("ClassNameRegexp")]
        public string ClassNameRegexp{ get; set; }

        /// <summary>
        /// Parent class name regular expression, which is not matched if empty.
        /// </summary>
        [JsonProperty("SuperClassNameRegexp")]
        public string SuperClassNameRegexp{ get; set; }

        /// <summary>
        /// Inherited interface regular expression, which is not matched if empty.
        /// </summary>
        [JsonProperty("InterfacesRegexp")]
        public string InterfacesRegexp{ get; set; }

        /// <summary>
        /// Annotation regular expression, which is not matched if empty.
        /// </summary>
        [JsonProperty("AnnotationsRegexp")]
        public string AnnotationsRegexp{ get; set; }

        /// <summary>
        /// Associated class loader regular expression, which is not matched if empty.
        /// </summary>
        [JsonProperty("LoaderClassNameRegexp")]
        public string LoaderClassNameRegexp{ get; set; }

        /// <summary>
        /// Operator
        /// </summary>
        [JsonProperty("Operator")]
        public string Operator{ get; set; }

        /// <summary>
        /// Whether it is a global rule. (Whether it is effective for all hosts under appid. 0: single UUID; 1: global. The default value is no.)
        /// </summary>
        [JsonProperty("IsGlobal")]
        public ulong? IsGlobal{ get; set; }

        /// <summary>
        /// Status (0: valid, 1: deleted, 2: invalid (enabling switch off)).
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// Creation time
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Modification time
        /// </summary>
        [JsonProperty("ModifyTime")]
        public string ModifyTime{ get; set; }

        /// <summary>
        /// Whether to process historical events. 0: no, 1: yes.
        /// </summary>
        [JsonProperty("HandleHistory")]
        public ulong? HandleHistory{ get; set; }

        /// <summary>
        /// Batch ID.
        /// </summary>
        [JsonProperty("GroupID")]
        public string GroupID{ get; set; }

        /// <summary>
        /// Number of servers covered by a rule. When IsGlobal is set to 1, all servers are displayed.
        /// </summary>
        [JsonProperty("MachinesNums")]
        public string MachinesNums{ get; set; }

        /// <summary>
        /// Policy name
        /// </summary>
        [JsonProperty("GroupName")]
        public string GroupName{ get; set; }

        /// <summary>
        /// Source code regular expression, which is not matched if empty.
        /// </summary>
        [JsonProperty("CodeSourceRegexp")]
        public string CodeSourceRegexp{ get; set; }

        /// <summary>
        /// Call stack regular expression, which is not matched if empty.
        /// </summary>
        [JsonProperty("CallStackRegexp")]
        public string CallStackRegexp{ get; set; }

        /// <summary>
        /// Whether a file exists. 0: Default value when a user does not select a rule. 1: File exists. 2: File does not exist.
        /// </summary>
        [JsonProperty("FileExist")]
        public ulong? FileExist{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamArrayObj(map, prefix + "UuidHostips.", this.UuidHostips);
            this.SetParamSimple(map, prefix + "LogicalSymbol", this.LogicalSymbol);
            this.SetParamSimple(map, prefix + "ClassNameRegexp", this.ClassNameRegexp);
            this.SetParamSimple(map, prefix + "SuperClassNameRegexp", this.SuperClassNameRegexp);
            this.SetParamSimple(map, prefix + "InterfacesRegexp", this.InterfacesRegexp);
            this.SetParamSimple(map, prefix + "AnnotationsRegexp", this.AnnotationsRegexp);
            this.SetParamSimple(map, prefix + "LoaderClassNameRegexp", this.LoaderClassNameRegexp);
            this.SetParamSimple(map, prefix + "Operator", this.Operator);
            this.SetParamSimple(map, prefix + "IsGlobal", this.IsGlobal);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "ModifyTime", this.ModifyTime);
            this.SetParamSimple(map, prefix + "HandleHistory", this.HandleHistory);
            this.SetParamSimple(map, prefix + "GroupID", this.GroupID);
            this.SetParamSimple(map, prefix + "MachinesNums", this.MachinesNums);
            this.SetParamSimple(map, prefix + "GroupName", this.GroupName);
            this.SetParamSimple(map, prefix + "CodeSourceRegexp", this.CodeSourceRegexp);
            this.SetParamSimple(map, prefix + "CallStackRegexp", this.CallStackRegexp);
            this.SetParamSimple(map, prefix + "FileExist", this.FileExist);
        }
    }
}

