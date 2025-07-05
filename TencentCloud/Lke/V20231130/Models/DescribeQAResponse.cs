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

namespace TencentCloud.Lke.V20231130.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeQAResponse : AbstractModel
    {
        
        /// <summary>
        /// Q&A business ID.
        /// </summary>
        [JsonProperty("QaBizId")]
        public string QaBizId{ get; set; }

        /// <summary>
        /// Question.
        /// </summary>
        [JsonProperty("Question")]
        public string Question{ get; set; }

        /// <summary>
        /// Answer.
        /// </summary>
        [JsonProperty("Answer")]
        public string Answer{ get; set; }

        /// <summary>
        /// Custom parameter.
        /// </summary>
        [JsonProperty("CustomParam")]
        public string CustomParam{ get; set; }

        /// <summary>
        /// Source:
        /// 1 - Q&A pairs generated from documents.
        /// 2 - Q&A pairs imported in batches.
        /// 3 - Q&A pairs input manually one by one.
        /// 
        /// </summary>
        [JsonProperty("Source")]
        public ulong? Source{ get; set; }

        /// <summary>
        /// Source description.
        /// </summary>
        [JsonProperty("SourceDesc")]
        public string SourceDesc{ get; set; }

        /// <summary>
        /// Update time.
        /// 
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// Status<br>1 - pending verification; 2 - not released; 3 - releasing; 4 - released; 5 - release failed; 6 - not approved; 7 - under review; 8 - review failed, 9 - review failed, pending manual review after appeal; 11 - review failed, manual review not passed after appeal; 12 - expired; 13 - excessive invalid; 14 - excessive invalid recovered; 19 - learning; 20 - learning failed.
        /// 
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// Status description.
        /// 
        /// </summary>
        [JsonProperty("StatusDesc")]
        public string StatusDesc{ get; set; }

        /// <summary>
        /// Category ID.
        /// </summary>
        [JsonProperty("CateBizId")]
        public string CateBizId{ get; set; }

        /// <summary>
        /// Whether verification is allowed.
        /// </summary>
        [JsonProperty("IsAllowAccept")]
        public bool? IsAllowAccept{ get; set; }

        /// <summary>
        /// Whether deletion is allowed.
        /// </summary>
        [JsonProperty("IsAllowDelete")]
        public bool? IsAllowDelete{ get; set; }

        /// <summary>
        /// Whether editing is allowed.
        /// </summary>
        [JsonProperty("IsAllowEdit")]
        public bool? IsAllowEdit{ get; set; }

        /// <summary>
        /// Document ID.
        /// </summary>
        [JsonProperty("DocBizId")]
        public string DocBizId{ get; set; }

        /// <summary>
        /// Document name.
        /// </summary>
        [JsonProperty("FileName")]
        public string FileName{ get; set; }

        /// <summary>
        /// Document type.
        /// </summary>
        [JsonProperty("FileType")]
        public string FileType{ get; set; }

        /// <summary>
        /// Segment ID.
        /// </summary>
        [JsonProperty("SegmentBizId")]
        public string SegmentBizId{ get; set; }

        /// <summary>
        /// Segment content.
        /// </summary>
        [JsonProperty("PageContent")]
        public string PageContent{ get; set; }

        /// <summary>
        /// Segment highlight content.
        /// </summary>
        [JsonProperty("Highlights")]
        public Highlight[] Highlights{ get; set; }

        /// <summary>
        /// Segment content.
        /// </summary>
        [JsonProperty("OrgData")]
        public string OrgData{ get; set; }

        /// <summary>
        /// Applicable scope of label.
        /// </summary>
        [JsonProperty("AttrRange")]
        public long? AttrRange{ get; set; }

        /// <summary>
        /// Label.
        /// </summary>
        [JsonProperty("AttrLabels")]
        public AttrLabel[] AttrLabels{ get; set; }

        /// <summary>
        /// Effective start time, unix timestamp.
        /// </summary>
        [JsonProperty("ExpireStart")]
        public string ExpireStart{ get; set; }

        /// <summary>
        /// Effective end time, unix timestamp. 0 indicates permanent validity.
        /// </summary>
        [JsonProperty("ExpireEnd")]
        public string ExpireEnd{ get; set; }

        /// <summary>
        /// Similar question list information.
        /// </summary>
        [JsonProperty("SimilarQuestions")]
        public SimilarQuestion[] SimilarQuestions{ get; set; }

        /// <summary>
        /// Review status of Q&A text: 1 - review failed.
        /// </summary>
        [JsonProperty("QaAuditStatus")]
        public ulong? QaAuditStatus{ get; set; }

        /// <summary>
        /// Review status of image in Q&A: 1-review failed.
        /// </summary>
        [JsonProperty("PicAuditStatus")]
        public ulong? PicAuditStatus{ get; set; }

        /// <summary>
        /// Review status of video in Q&A: 1 - review failed.
        /// </summary>
        [JsonProperty("VideoAuditStatus")]
        public ulong? VideoAuditStatus{ get; set; }

        /// <summary>
        /// Question description.
        /// </summary>
        [JsonProperty("QuestionDesc")]
        public string QuestionDesc{ get; set; }

        /// <summary>
        /// The unique request ID, generated by the server, will be returned for every request (if the request fails to reach the server for other reasons, the request will not obtain a RequestId). RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "QaBizId", this.QaBizId);
            this.SetParamSimple(map, prefix + "Question", this.Question);
            this.SetParamSimple(map, prefix + "Answer", this.Answer);
            this.SetParamSimple(map, prefix + "CustomParam", this.CustomParam);
            this.SetParamSimple(map, prefix + "Source", this.Source);
            this.SetParamSimple(map, prefix + "SourceDesc", this.SourceDesc);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "StatusDesc", this.StatusDesc);
            this.SetParamSimple(map, prefix + "CateBizId", this.CateBizId);
            this.SetParamSimple(map, prefix + "IsAllowAccept", this.IsAllowAccept);
            this.SetParamSimple(map, prefix + "IsAllowDelete", this.IsAllowDelete);
            this.SetParamSimple(map, prefix + "IsAllowEdit", this.IsAllowEdit);
            this.SetParamSimple(map, prefix + "DocBizId", this.DocBizId);
            this.SetParamSimple(map, prefix + "FileName", this.FileName);
            this.SetParamSimple(map, prefix + "FileType", this.FileType);
            this.SetParamSimple(map, prefix + "SegmentBizId", this.SegmentBizId);
            this.SetParamSimple(map, prefix + "PageContent", this.PageContent);
            this.SetParamArrayObj(map, prefix + "Highlights.", this.Highlights);
            this.SetParamSimple(map, prefix + "OrgData", this.OrgData);
            this.SetParamSimple(map, prefix + "AttrRange", this.AttrRange);
            this.SetParamArrayObj(map, prefix + "AttrLabels.", this.AttrLabels);
            this.SetParamSimple(map, prefix + "ExpireStart", this.ExpireStart);
            this.SetParamSimple(map, prefix + "ExpireEnd", this.ExpireEnd);
            this.SetParamArrayObj(map, prefix + "SimilarQuestions.", this.SimilarQuestions);
            this.SetParamSimple(map, prefix + "QaAuditStatus", this.QaAuditStatus);
            this.SetParamSimple(map, prefix + "PicAuditStatus", this.PicAuditStatus);
            this.SetParamSimple(map, prefix + "VideoAuditStatus", this.VideoAuditStatus);
            this.SetParamSimple(map, prefix + "QuestionDesc", this.QuestionDesc);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

