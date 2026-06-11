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

    public class YDRaspBlackWhiteListItem : AbstractModel
    {
        
        /// <summary>
        /// Rule ID
        /// </summary>
        [JsonProperty("Id")]
        public ulong? Id{ get; set; }

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
        /// Allowlist type, rasp: vulnerability defense, memshell_scan: Java Webshell scan, memshell_inject: memory shell injection
        /// </summary>
        [JsonProperty("Source")]
        public string Source{ get; set; }

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
        /// Java Webshell scan usage, process historical events, 0: do not process 1: process
        /// </summary>
        [JsonProperty("HandleHistory")]
        public ulong? HandleHistory{ get; set; }

        /// <summary>
        /// rasp and memory shell injection usage, match content, POC, can be a regular expression (MatchMode=5) or a string.
        /// </summary>
        [JsonProperty("Content")]
        public string Content{ get; set; }

        /// <summary>
        /// rasp and memory shell injection usage, attack source ip, leave unset for all sources, multiple allowed, can have ip ranges, such as: 192.168.57.1/24;172.17.0.1
        /// </summary>
        [JsonProperty("IP")]
        public string IP{ get; set; }

        /// <summary>
        /// Rule name
        /// </summary>
        [JsonProperty("PolicyName")]
        public string PolicyName{ get; set; }

        /// <summary>
        /// rasp and memory shell injection usage, allowlisting method, 0: malicious feature allowlisting, 1: request URL allowlisting
        /// </summary>
        [JsonProperty("FilterType")]
        public long? FilterType{ get; set; }

        /// <summary>
        /// RASP and memory shell injection usage, attack type, vul.rasp_attacktype_mapping attack_type_id field
        /// </summary>
        [JsonProperty("AttackType")]
        public long? AttackType{ get; set; }

        /// <summary>
        /// rasp and memory shell injection usage, match mode, 0: exact match, 1: prefix match, 2: suffix matching, 4: arbitrary matching, 5: partial matching, 6: regular expression matching.
        /// </summary>
        [JsonProperty("MatchMode")]
        public long? MatchMode{ get; set; }

        /// <summary>
        /// Effective asset type. 0: Host disabled. 1: Host enabled.
        /// </summary>
        [JsonProperty("CWPEffective")]
        public long? CWPEffective{ get; set; }

        /// <summary>
        /// 0: a set of quuid 1: ALL the Real Server with host authorization
        /// </summary>
        [JsonProperty("CWPScope")]
        public long? CWPScope{ get; set; }

        /// <summary>
        /// Designate the effective host machine
        /// </summary>
        [JsonProperty("CWPQuuids")]
        public string[] CWPQuuids{ get; set; }

        /// <summary>
        /// Effective asset type. 0: Container disabled. 1: Container enabled.
        /// </summary>
        [JsonProperty("TCSSEffective")]
        public long? TCSSEffective{ get; set; }

        /// <summary>
        /// 0: a set of quuid 1: ALL the node with container authorization
        /// </summary>
        [JsonProperty("TCSSScope")]
        public long? TCSSScope{ get; set; }

        /// <summary>
        /// Designate the container node to take effect
        /// </summary>
        [JsonProperty("TCSSQuuids")]
        public string[] TCSSQuuids{ get; set; }

        /// <summary>
        /// Effective asset type. 0: Super node disabled. 1: Super node enabled.
        /// </summary>
        [JsonProperty("EksEffective")]
        public long? EksEffective{ get; set; }

        /// <summary>
        /// 0: a set of quuid 1: ALL the super node with container authorization
        /// </summary>
        [JsonProperty("EksScope")]
        public long? EksScope{ get; set; }

        /// <summary>
        /// Designate the super node where the container takes effect
        /// </summary>
        [JsonProperty("EksNodeUniqueID")]
        public string[] EksNodeUniqueID{ get; set; }

        /// <summary>
        /// Application asset. If global, all hosts. Otherwise, the number of selected host servers.
        /// </summary>
        [JsonProperty("CWPMachinesNums")]
        public string CWPMachinesNums{ get; set; }

        /// <summary>
        /// Application asset. If global, all containers host nodes. Otherwise, select the number of host nodes.
        /// </summary>
        [JsonProperty("TCSSMachinesNums")]
        public string TCSSMachinesNums{ get; set; }

        /// <summary>
        /// Application asset. If global, all super nodes. Otherwise, select the number of nodes.
        /// </summary>
        [JsonProperty("EksMachinesNums")]
        public string EksMachinesNums{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "LogicalSymbol", this.LogicalSymbol);
            this.SetParamSimple(map, prefix + "ClassNameRegexp", this.ClassNameRegexp);
            this.SetParamSimple(map, prefix + "SuperClassNameRegexp", this.SuperClassNameRegexp);
            this.SetParamSimple(map, prefix + "InterfacesRegexp", this.InterfacesRegexp);
            this.SetParamSimple(map, prefix + "AnnotationsRegexp", this.AnnotationsRegexp);
            this.SetParamSimple(map, prefix + "LoaderClassNameRegexp", this.LoaderClassNameRegexp);
            this.SetParamSimple(map, prefix + "Source", this.Source);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "ModifyTime", this.ModifyTime);
            this.SetParamSimple(map, prefix + "HandleHistory", this.HandleHistory);
            this.SetParamSimple(map, prefix + "Content", this.Content);
            this.SetParamSimple(map, prefix + "IP", this.IP);
            this.SetParamSimple(map, prefix + "PolicyName", this.PolicyName);
            this.SetParamSimple(map, prefix + "FilterType", this.FilterType);
            this.SetParamSimple(map, prefix + "AttackType", this.AttackType);
            this.SetParamSimple(map, prefix + "MatchMode", this.MatchMode);
            this.SetParamSimple(map, prefix + "CWPEffective", this.CWPEffective);
            this.SetParamSimple(map, prefix + "CWPScope", this.CWPScope);
            this.SetParamArraySimple(map, prefix + "CWPQuuids.", this.CWPQuuids);
            this.SetParamSimple(map, prefix + "TCSSEffective", this.TCSSEffective);
            this.SetParamSimple(map, prefix + "TCSSScope", this.TCSSScope);
            this.SetParamArraySimple(map, prefix + "TCSSQuuids.", this.TCSSQuuids);
            this.SetParamSimple(map, prefix + "EksEffective", this.EksEffective);
            this.SetParamSimple(map, prefix + "EksScope", this.EksScope);
            this.SetParamArraySimple(map, prefix + "EksNodeUniqueID.", this.EksNodeUniqueID);
            this.SetParamSimple(map, prefix + "CWPMachinesNums", this.CWPMachinesNums);
            this.SetParamSimple(map, prefix + "TCSSMachinesNums", this.TCSSMachinesNums);
            this.SetParamSimple(map, prefix + "EksMachinesNums", this.EksMachinesNums);
        }
    }
}

