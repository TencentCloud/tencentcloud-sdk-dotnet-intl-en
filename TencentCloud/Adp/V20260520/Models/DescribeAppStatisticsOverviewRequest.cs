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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeAppStatisticsOverviewRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Application type. Available values: APP_TYPE_RAG (RAG), APP_TYPE_WORKFLOW (Workflow), APP_TYPE_CLAW (Claw), APP_TYPE_MULTIAGENT (MultiAgent). In the current period, only APP_TYPE_RAG takes effect. The rest are reserved values. Importing them will return InvalidParameter.</p><table><tbody><tr><td>Enumeration item</td><td>Enumeration value</td><td>Description</td></tr><tr><td>APP_TYPE_UNSPECIFIED</td><td>0</td><td>Unspecified (invalid value, do not import in requests)</td></tr><tr><td>APP_TYPE_RAG</td><td>1</td><td>RAG (uniquely supported in the current period)</td></tr><tr><td>APP_TYPE_WORKFLOW</td><td>2</td><td>Workflow (reserved, not currently supported)</td></tr><tr><td>APP_TYPE_CLAW</td><td>3</td><td>Claw (reserved, not currently supported)</td></tr><tr><td>APP_TYPE_MULTIAGENT</td><td>4</td><td>MultiAgent (reserved, not currently supported)</td></tr></tbody></table>
        /// </summary>
        [JsonProperty("AppType")]
        public long? AppType{ get; set; }

        /// <summary>
        /// <p>Query time range (Unix seconds)</p>
        /// </summary>
        [JsonProperty("TimeRange")]
        public TimeRange TimeRange{ get; set; }

        /// <summary>
        /// <p>View scope: application view (VIEW_TYPE_APP). For scope_id, enter the app ID (decimal string of the uint64 snowflake ID)</p>
        /// </summary>
        [JsonProperty("ViewScope")]
        public ViewScope ViewScope{ get; set; }

        /// <summary>
        /// <p>Space ID</p><p>Parameter format: <p>Space ID</p></p><p>Default value: default_space</p>
        /// </summary>
        [JsonProperty("SpaceId")]
        public string SpaceId{ get; set; }

        /// <summary>
        /// <p>Application ID</p><p>Parameter format:</p><p>Application ID</p><p></p><p>Reference value: 2099767969573745984</p>
        /// </summary>
        [JsonProperty("AppId")]
        public string AppId{ get; set; }

        /// <summary>
        /// <p>Extended filtering. Filter combination rule: multiple items use AND, and value_list under the same item uses OR. Supported Name: space_id (Space ID), channel_type (calling method/channel type; for values, see the trpc.adp.common.v2.ChannelType Enumeration Name). If channel_type is not specified, aggregation is performed by all channels.</p>
        /// </summary>
        [JsonProperty("FilterList")]
        public Filter[] FilterList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppType", this.AppType);
            this.SetParamObj(map, prefix + "TimeRange.", this.TimeRange);
            this.SetParamObj(map, prefix + "ViewScope.", this.ViewScope);
            this.SetParamSimple(map, prefix + "SpaceId", this.SpaceId);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamArrayObj(map, prefix + "FilterList.", this.FilterList);
        }
    }
}

