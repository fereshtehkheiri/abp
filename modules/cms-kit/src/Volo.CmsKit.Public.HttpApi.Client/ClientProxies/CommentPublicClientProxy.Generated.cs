// This file is automatically generated by ABP framework to use MVC Controllers from CSharp
using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Http.Client;
using Volo.Abp.Http.Modeling;
using Volo.CmsKit.Public.Comments;

// ReSharper disable once CheckNamespace
namespace Volo.CmsKit.Public.Comments.ClientProxies
{
    public partial class CommentPublicClientProxy
    {
        public virtual async Task<ListResultDto<CommentWithDetailsDto>> GetListAsync(string entityType, string entityId)
        {
            return await RequestAsync<ListResultDto<CommentWithDetailsDto>>(nameof(GetListAsync), entityType, entityId);
        }

        public virtual async Task<CommentDto> CreateAsync(string entityType, string entityId, CreateCommentInput input)
        {
            return await RequestAsync<CommentDto>(nameof(CreateAsync), entityType, entityId, input);
        }

        public virtual async Task<CommentDto> UpdateAsync(Guid id, UpdateCommentInput input)
        {
            return await RequestAsync<CommentDto>(nameof(UpdateAsync), id, input);
        }

        public virtual async Task DeleteAsync(Guid id)
        {
            await RequestAsync(nameof(DeleteAsync), id);
        }
    }
}