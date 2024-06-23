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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RuleGroupTable : AbstractModel
    {
        
        /// <summary>
        /// Table Information
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("TableInfo")]
        public RuleGroupTableInnerInfo TableInfo{ get; set; }

        /// <summary>
        /// Rule Group Scheduling Information
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("RuleGroups")]
        public RuleGroupSchedulerInfo[] RuleGroups{ get; set; }

        /// <summary>
        /// Subscriber Information
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("Subscriptions")]
        public RuleGroupSubscribe[] Subscriptions{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "TableInfo.", this.TableInfo);
            this.SetParamArrayObj(map, prefix + "RuleGroups.", this.RuleGroups);
            this.SetParamArrayObj(map, prefix + "Subscriptions.", this.Subscriptions);
        }
    }
}

