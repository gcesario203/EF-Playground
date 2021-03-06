using Microsoft.AspNetCore.Mvc;
using Library.Controllers.Interfaces;
using Library.Repositories.Base;
using Library.Models;
using Library.Contexts;
using Microsoft.AspNetCore.Authorization;
using Library.Utils.Generals;

namespace Library.Controllers.Base
{
    public abstract class BaseController<T, V, G, S> : ControllerBase, IBaseController<V>
        where T : BaseRepository<V, G, S>
        where G : BaseEntity
        where S : BaseDBContext<S>
    {
        protected T _repository;

        public BaseController(T repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        [HttpGet]
        public virtual async Task<ActionResult<IEnumerable<V>>> FindAll()
        {
            var items = await _repository.FindAll();

            return Ok(items);
        }

        [HttpGet("{id}")]
        public virtual async Task<ActionResult<V>> FindById(long id)
        {
            var item = await _repository.FindById(id);

            if (item == null) return NotFound();

            return Ok(item);
        }

        [HttpPost]
        public virtual async Task<ActionResult<V>> Create([FromBody] V vo)
        {
            if (vo == null) return BadRequest();

            var item = await _repository.Create(vo);

            return Ok(item);
        }

        [HttpPut]
        public virtual async Task<ActionResult<V>> Update([FromBody] V vo)
        {
            if (vo == null) return BadRequest();

            var item = await _repository.Update(vo);

            return Ok(item);
        }

        [HttpDelete("{id}")]
        public virtual async Task<ActionResult> Delete(long id)
        {
            var status = await _repository.Delete(id);

            if (!status) return BadRequest();

            return Ok(status);
        }
    }
}