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

    public class DescribeMsgRecordListRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Application ID</p>
        /// </summary>
        [JsonProperty("AppId")]
        public string AppId{ get; set; }

        /// <summary>
        /// <ul><li><strong>ChannelType</strong> : 0-all 2-experience page (Tencent Cloud) 3-web debugging page (Tencent Cloud) 4-experience page (phone number) 5-dialogue API connection 6-application evaluation 7-debug API 10000-WeChat service account 10001-WeChat Subscription Account 10002-WeCom app 10004-WeChat Customer Service 10005-WeChat mini program 10006-Tencent Yuanqi 10007-App Treasure 10009-WeCom intelligent bot 10014-WeCom intelligent bot 10011-LINE 10012-Telegram 10013-DingTalk chatbot 10016-Lark chatbot 30000-scheduled task 30001-trigger </li><li><strong>FeedbackType</strong> : feedback type, -1-all 0-not rated 1-like 2-dislike </li><li><strong>QueryType</strong> : retrieval type (take value as agreed by the platform), SessionId-sessionID Question-question Answer-reply Intent-intent User-user </li><li><strong>Query</strong> : filter criteria corresponding to QueryType </li><li><strong>CategoryId</strong> : category ID </li><li><strong>ReplyMethod</strong> : reply type 0-all reply types 1-reply to rejected questions 2-direct QA reply 3-review failure reply 4-knowledge polish reply 6-workflow reply 8-image understanding reply 9-search engine reply 10-large model direct reply 11-fallback response </li><li><strong>StartTime</strong> : start time, unix second-level timestamp </li><li><strong>EndTime</strong> : end time, unix second-level timestamp </li><li><strong>Cursor</strong> : cursor. For the previous page, take PrevCursor from the response; for the next page, take NextCursor from the response. </li><li><strong>Direction</strong> : direction. next: next page, prev: previous page</li><li><strong>CallResult</strong> : call result: 0-all / 1-success / 2-failure / 3-canceled by the user </li><li><strong>FailReason</strong> : failure reason 0-all 1-review failure 2-QPM limit reached 3-TPM limit reached 4-concurrency limit reached 5-system exception </li><li><strong>Intent</strong> : intent</li></ul>
        /// </summary>
        [JsonProperty("FilterList")]
        public Filter[] FilterList{ get; set; }

        /// <summary>
        /// <p>Page number, starting from 0. If not passed, it is processed as 0.</p>
        /// </summary>
        [JsonProperty("PageNumber")]
        public ulong? PageNumber{ get; set; }

        /// <summary>
        /// <p>Number of items per page. Maximum value: 100. If not specified or set to 0, the default pagination size is used.</p>
        /// </summary>
        [JsonProperty("PageSize")]
        public ulong? PageSize{ get; set; }

        /// <summary>
        /// <p>Sort condition. Supports sorting by CreateTime only</p>
        /// </summary>
        [JsonProperty("Sort")]
        public Sort Sort{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamArrayObj(map, prefix + "FilterList.", this.FilterList);
            this.SetParamSimple(map, prefix + "PageNumber", this.PageNumber);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamObj(map, prefix + "Sort.", this.Sort);
        }
    }
}

